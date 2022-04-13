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
    public partial class Inscribir : Form
    {

        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;

        public Inscribir()
        {
            InitializeComponent();
            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }

        private void inscribirEst_Click(object sender, EventArgs e)
        {

            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO  EstudianteClase VALUES(@EstudianteId, @ClasesId)", connection))
            {
                try
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@EstudianteId", IDest.Text);
                    command.Parameters.AddWithValue("@ClasesId", IDclas.Text);

                    command.ExecuteScalar();

                    MessageBox.Show("El estudiante ha sido inscrito correctamente :)");
                }
                catch (Exception)
                {

                    MessageBox.Show("Error con el ID. Intente de nuevo.");
                }
       
            }
        }

        private void Inscribir_Load(object sender, EventArgs e)
        {
        

        }
    }
}
