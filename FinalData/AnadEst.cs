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
    public partial class AnadEst : Form
    {
       

        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;



        public AnadEst()
        {
            InitializeComponent();

            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }

      

        private void anadir_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConnectionString))
            {

                using (connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("INSERT INTO  Estudiante VALUES(@Nombre, @Edad, @Email, @Telefono)", connection))
                {

                    connection.Open();

                    command.Parameters.AddWithValue("@Nombre", nombre.Text);
                    command.Parameters.AddWithValue("@Edad", edad.Text);
                    command.Parameters.AddWithValue("@Email", email.Text);
                    command.Parameters.AddWithValue("@Telefono", telefono.Text);

                    command.ExecuteScalar();

                    MessageBox.Show("El estudiante ha sido añadido correctamente :)");

                }

            }

        }
    }
}
