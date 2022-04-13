using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalData
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'generalDataSet.Estudiante' table. You can move, or remove it, as needed.
            this.estudianteTableAdapter.Fill(this.generalDataSet.Estudiante);
        }


        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        
        }

        private void estudianteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
         

        }

        private void estudianteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();

        }

        private void estudianteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
