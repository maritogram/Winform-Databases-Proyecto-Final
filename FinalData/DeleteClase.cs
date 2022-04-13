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
    public partial class DeleteClase : Form
    {


         //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;
        public DeleteClase()
        {
            InitializeComponent();
            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }

        private void elimi_Click_1(object sender, EventArgs e)
        {

            using(connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM EstudianteClase WHERE Clase = @Código ", connection))
            {

                connection.Open();

                command.Parameters.AddWithValue("@Código", IDclas.Text);

                command.ExecuteScalar();

            }

            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM Clases WHERE Código = @Código ", connection))
            {

                connection.Open();

                command.Parameters.AddWithValue("@Código", IDclas.Text);

                command.ExecuteScalar();

            }

            MessageBox.Show("La clase ha sido eliminado correctamente :)");
        }

        private void todo_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM EstudianteClase ", connection))
            {

                connection.Open();

                command.Parameters.AddWithValue("@Código", IDclas.Text);

                command.ExecuteScalar();

            }

            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM Clases ", connection))
            {

                connection.Open();

                command.Parameters.AddWithValue("@Código", IDclas.Text);

                command.ExecuteScalar();

            }

            MessageBox.Show("Todas las clases han sido eliminadas correctamente.");
        }
    }
}
