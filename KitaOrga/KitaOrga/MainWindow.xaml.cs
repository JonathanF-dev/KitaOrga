using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace KitaOrga
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    /// 


    class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public User(string password, string username)
        {
            this.username = username;
            this.password = password;
        }

    }
    public class Login
    {
        
        private static User user;

        public Login(string password, string username)
        {
            user = new User(password, username);
        } 


        internal User getUser()
        {
            return user; 
        }



    }
    class csvData
    {


        public string getUsername()
        {
            string[] data = readloginData("MySql.txt");
            string username = data[1];
            return username;
        }

        public string getPassword()
        {
            string[] data = readloginData("MySql.txt");
            string password = data[0];
            return password;
        }

        public static void addloginData(string password, string username, string filepath)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, false))
                file.WriteLine(password + "," + username);
        }

        public static string[] readloginData(string filepath)
        {
            string[] loginData = System.IO.File.ReadAllLines(@filepath);
            string[] loginDataNotFound = { "logindata not found" };
            for (int i = 0; i < loginData.Length; i++)
            {
                string[] fields = loginData[i].Split(',');
                return fields;
            }
            return loginDataNotFound;
        }
    }

    class Connection
    {
        private string username;
        private string password;
        public Connection(string password, string username)
        {
            this.password = password;
            this.username = username;
        }
        public string Connect()
        {
            string admin_connection = "SERVER=127.0.0.1;" +
                "DATABASE=KitaOrga;" +
                "port=3306;" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";" +
                "SSLMODE=Preferred;";
            return admin_connection;
        }

        public MySqlConnection Admin_connect()
        {
            MySqlConnection admin_connection = new MySqlConnection(Connect());
            return admin_connection;
        }
    }

    public partial class MainWindow : Window
    {

        
        
        public MainWindow()
        {
            InitializeComponent();            
            
        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PasswordBox pwBox = new PasswordBox();
            pwBox.Password = pb_pwdBox.Password;
            Login login = new Login(pwBox.Password, Tb_Benutzername.Text);
            User user = login.getUser();
            csvData data = new csvData();
            Connection connection = new Connection(data.getPassword(), data.getUsername());

            MessageBox.Show(data.getUsername(), data.getPassword());

            try
            {
                connection.Admin_connect().Open();
                connection.Admin_connect().Close();
                KitaOrga_MainWindow Mitarbeiter = new KitaOrga_MainWindow();
                Mitarbeiter.Show();
                this.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }






        }



    }
}
