using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace FinalData
{
    public partial class LoginStart : Form
    {

        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;


        public LoginStart()
        {
            InitializeComponent();

            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string ID = textBox1.Text;
            string PIN = textBox2.Text;

            using (connection = new SqlConnection(ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Login WHERE Username = '" + ID + "' AND Password COLLATE Latin1_General_CS_AS = '" + PIN + "'", connection))
            {
                 try
                {
                  
                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {

                        MenuDesp Form2 = new MenuDesp();
                        Form2.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Incorrecto");
                    }


                }
              catch (Exception)
                {

               MessageBox.Show("Error");
                }
              //  finally
                {

                }

            }


        }

        private void LoginStart_Load(object sender, EventArgs e)
        {

        }
    }
}
