
namespace FinalData
{
    partial class EliminarInscripcion
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
            this.retirar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDest = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.Label();
            this.IDclas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // retirar
            // 
            this.retirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.retirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.retirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retirar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.retirar.Location = new System.Drawing.Point(209, 126);
            this.retirar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(183, 53);
            this.retirar.TabIndex = 34;
            this.retirar.Text = "Retirar";
            this.retirar.UseVisualStyleBackColor = false;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            this.label1.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID del estudiante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDest
            // 
            this.IDest.Location = new System.Drawing.Point(82, 71);
            this.IDest.Margin = new System.Windows.Forms.Padding(4);
            this.IDest.Name = "IDest";
            this.IDest.Size = new System.Drawing.Size(120, 22);
            this.IDest.TabIndex = 32;
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            this.n.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.ForeColor = System.Drawing.Color.Snow;
            this.n.Location = new System.Drawing.Point(330, 9);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(261, 37);
            this.n.TabIndex = 31;
            this.n.Text = "Código de la clase";
            this.n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDclas
            // 
            this.IDclas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.IDclas.Location = new System.Drawing.Point(396, 71);
            this.IDclas.Margin = new System.Windows.Forms.Padding(4);
            this.IDclas.Name = "IDclas";
            this.IDclas.Size = new System.Drawing.Size(120, 22);
            this.IDclas.TabIndex = 30;
            // 
            // EliminarInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 483);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDest);
            this.Controls.Add(this.n);
            this.Controls.Add(this.IDclas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarInscripcion";
            this.Text = "EliminarInscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDest;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox IDclas;
    }
}