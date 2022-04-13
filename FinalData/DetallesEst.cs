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
    public partial class DetallesEst : Form
    {

        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;

        public DetallesEst()
        {
            InitializeComponent();
            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }
        private void DetallesEst_Load(object sender, EventArgs e)
        {
          
        }



        // A REVISARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR       NOMBRE DE CLASE
        private void Populate()
        {
            string query = "SELECT a.Código, a.Asignatura, a.Cr, a.Lun, a.Ma,a.Mi, a.Ju, a.Vi, a.Sa, a.Profesor  " +
                "FROM Clases a " +
                "INNER JOIN EstudianteClase b ON a.Código = b.Clase " +
                "WHERE b.Estudiante = @Estudiante";

            using (connection = new SqlConnection(ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Estudiante", telefono.Text);

                DataTable test = new DataTable();
                adapter.Fill(test);

                datates.DataSource = test;
            }
        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void datates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
