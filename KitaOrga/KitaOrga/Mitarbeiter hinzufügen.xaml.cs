using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KitaOrga
{
    /// <summary>
    /// Interaktionslogik für Mitarbeiter_hinzufügen.xaml
    /// </summary>
    public partial class Mitarbeiter_hinzufügen : Window
    {

        class Employee
        {
            public string Name { get; set; }
            public string Gruppe { get; set; }
            public string Stelle { get; set; }
            public double Stunden { get; set; }


            public Employee(string name, string gruppe, string stelle, double stunden)
            {
                this.Name = name;
                this.Gruppe = gruppe;
                this.Stelle = stelle;
                this.Stunden = stunden;
            }


            public string GetName()
            {
                return this.Name;
            }

            public string GetGruppe()
            {
                return this.Gruppe;
            }

            public string GetStelle()
            {
                return this.Stelle;
            }

            public double GetStunden()
            {
                return this.Stunden;
            }
        }
        public Mitarbeiter_hinzufügen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //Login login = new Login();
            //User user = login.getUser();

            //Employee new_employee = new Employee(tb_Name.Text, tb_Gruppe.Text, tb_Stelle.Text, double.Parse(tb_Stunden.Text));

            //string sql_ma_hinzufügen = "INSERT INTO Mitarbeiter VALUES('" + new_employee.GetName() + "','" + new_employee.GetStelle() + "','" + new_employee.GetGruppe() + "'," + new_employee.GetStunden() + ");";

            //MySqlCommand ma_hinzufügen = new MySqlCommand(sql_ma_hinzufügen);



            //ma_hinzufügen.ExecuteNonQuery();
            //connection.Close();

        }
    }
}
