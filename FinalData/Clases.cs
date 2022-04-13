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
    public partial class Clases : Form
    {
        public Clases()
        {
            InitializeComponent();
        }

        private void clasesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clasesBindingSource.EndEdit();

        }

        private void Clases_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'generalDataSet.Clases' table. You can move, or remove it, as needed.
            this.clasesTableAdapter.Fill(this.generalDataSet.Clases);

        }

        private void clasesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
