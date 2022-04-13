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
    public partial class DeleteEstudiante : Form
    {
        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;


        public DeleteEstudiante()
        {
            InitializeComponent();

            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }

   
        private void elimi_Click(object sender, EventArgs e)
        {

            try
            {
                using (connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("DELETE FROM EstudianteClase WHERE Estudiante = @Id ", connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Id", IDest.Text);

                    command.ExecuteScalar();
                }

                using (connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand("DELETE FROM Estudiante WHERE ID = @Id ", connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Id", IDest.Text);

                    command.ExecuteScalar();
                }


                MessageBox.Show("El estudiante ha sido eliminado correctamente :)");

            }
            catch (Exception)
            {
                MessageBox.Show("Error con el ID. Intente de nuevo.");
            }

        }

        private void todo_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM EstudianteClase  ", connection))
            {
                connection.Open();

                command.ExecuteScalar();
            }

            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("DELETE FROM Estudiante ", connection))
            {
                connection.Open();

                command.ExecuteScalar();
            }

            MessageBox.Show("Todos los estudiantes fueron eliminados con exito.");

        }
    }
}
