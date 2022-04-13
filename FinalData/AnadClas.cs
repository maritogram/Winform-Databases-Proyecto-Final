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
    public partial class AnadClas : Form
    {

        //Pasar esta conexion a objetos para devolver los datos de la base de datos.
        SqlConnection connection;

        //ConnectionString basicamente nos dice donde esta nuestra base de datos, como nos conectamos, que credenciales usar, etc...
        string ConnectionString;

        public AnadClas()
        {
            InitializeComponent();

            ConnectionString = "Data Source=DESKTOP-0ROD6UC;Initial Catalog=Final;Integrated Security=True";
        }


        private void anadir1_Click(object sender, EventArgs e)
        {


            try
            {

                    using (connection = new SqlConnection(ConnectionString))
                    using (SqlCommand command = new SqlCommand("INSERT INTO Clases VALUES(@Código, @Asignatura, @Cr, @Lun, @Ma, @Mi, @Ju, @Vi, @Sa, @Profesor)", connection))
                    {

                        connection.Open();

                        command.Parameters.AddWithValue("@Código", Codigo.Text);
                        command.Parameters.AddWithValue("@Asignatura", asig.Text);
                        command.Parameters.AddWithValue("@Cr", Crs.Text);
                        command.Parameters.AddWithValue("@Lun", Lu.Text);
                        command.Parameters.AddWithValue("@Ma", Ma.Text);
                        command.Parameters.AddWithValue("@Mi", Mi.Text);
                        command.Parameters.AddWithValue("@Ju", Ju.Text);
                        command.Parameters.AddWithValue("@Vi", Vi.Text);
                        command.Parameters.AddWithValue("@Sa", Sa.Text);
                        command.Parameters.AddWithValue("@Profesor", Prof.Text);

                        command.ExecuteScalar();

                 
                      MessageBox.Show("La clase ha sido añadida correctamente :)");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor inserte una nueva clase o seccion.");
            }
            
        }
    }
}

