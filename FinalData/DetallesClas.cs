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
    public partial class DetallesClas : Form
    {

        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;

        public DetallesClas()
        {
            InitializeComponent();
            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }

        private void PopulateClas()
        {
            string query = "SELECT a.ID, a.Nombre, a.Edad, a.Email, a.Teléfono  " +
                "FROM Estudiante a " +
                "INNER JOIN EstudianteClase b ON a.ID = b.Estudiante " +
                "WHERE b.Clase = @Clase";

            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Clase", clasecode.Text);

                DataTable gest = new DataTable();
                adapter.Fill(gest);

                datacla.DataSource = gest;
            }
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            PopulateClas();
        }
    }
}
