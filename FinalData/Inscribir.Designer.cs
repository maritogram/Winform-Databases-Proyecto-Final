
namespace FinalData
{
    partial class Inscribir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.n = new System.Windows.Forms.Label();
            this.IDclas = new System.Windows.Forms.TextBox();
            this.inscribirEst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            this.n.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.ForeColor = System.Drawing.Color.Snow;
            this.n.Location = new System.Drawing.Point(333, 11);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(261, 37);
            this.n.TabIndex = 25;
            this.n.Text = "Código de la clase";
            this.n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDclas
            // 
            this.IDclas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IDclas.Location = new System.Drawing.Point(399, 73);
            this.IDclas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDclas.Name = "IDclas";
            this.IDclas.Size = new System.Drawing.Size(120, 22);
            this.IDclas.TabIndex = 24;
            // 
            // inscribirEst
            // 
            this.inscribirEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.inscribirEst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inscribirEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscribirEst.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscribirEst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inscribirEst.Location = new System.Drawing.Point(212, 128);
            this.inscribirEst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inscribirEst.Name = "inscribirEst";
            this.inscribirEst.Size = new System.Drawing.Size(183, 53);
            this.inscribirEst.TabIndex = 29;
            this.inscribirEst.Text = "Inscribir";
            this.inscribirEst.UseVisualStyleBackColor = false;
            this.inscribirEst.Click += new System.EventHandler(this.inscribirEst_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID del estudiante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDest
            // 
            this.IDest.Location = new System.Drawing.Point(85, 73);
            this.IDest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDest.Name = "IDest";
            this.IDest.Size = new System.Drawing.Size(120, 22);
            this.IDest.TabIndex = 27;
            // 
            // Inscribir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 497);
            this.Controls.Add(this.inscribirEst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDest);
            this.Controls.Add(this.n);
            this.Controls.Add(this.IDclas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inscribir";
            this.Text = "Inscribir";
            this.Load += new System.EventHandler(this.Inscribir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox IDclas;
        private System.Windows.Forms.Button inscribirEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDest;
    }
}