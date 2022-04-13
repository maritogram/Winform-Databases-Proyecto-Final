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
    public partial class MenuDesp : Form
    {
        public MenuDesp()
        {
            InitializeComponent();
        }

        private void MenuDesp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //------------------------------







        //Diferentes opciones: visualizar estudiantes, agregar, borrar, clases, etc..

        private void abrirPanelenForm(object childform)
        {
            if (this.Container.Controls.Count > 0)
                this.Container.Controls.RemoveAt(0);

            Form fh = childform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Container.Controls.Add(fh);
            this.Container.Tag = fh;
            fh.Show();
        }
        
        private void Estudiantes_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new Estudiantes());
        }

        private void EstuAdd_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new AnadEst());
        }

        private void Clases_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new Clases());
        }

        private void Clase_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new AnadClas());
        }

        private void ElimNam_Click_1(object sender, EventArgs e)
        {
            abrirPanelenForm(new DeleteEstudiante());
        }

        private void ElimClas_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new DeleteClase());
        }

        private void inscribir_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new Inscribir());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new DetallesEst());
        }

        private void Retirar_Click(object sender, EventArgs e)
        {
            abrirPanelenForm(new EliminarInscripcion());
        }
    }
}
