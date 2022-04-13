
namespace FinalData
{
    partial class DeleteClase
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
            this.elimi = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.Label();
            this.IDclas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // elimi
            // 
            this.elimi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.elimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.elimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elimi.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elimi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.elimi.Location = new System.Drawing.Point(41, 84);
            this.elimi.Margin = new System.Windows.Forms.Padding(2);
            this.elimi.Name = "elimi";
            this.elimi.Size = new System.Drawing.Size(137, 43);
            this.elimi.TabIndex = 23;
            this.elimi.Text = "Eliminar";
            this.elimi.UseVisualStyleBackColor = false;
            this.elimi.Click += new System.EventHandler(this.elimi_Click_1);
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            this.n.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.ForeColor = System.Drawing.Color.Snow;
            this.n.Location = new System.Drawing.Point(11, 9);
            this.n.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(196, 30);
            this.n.TabIndex = 22;
            this.n.Text = "Código de la clase";
            this.n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDclas
            // 
            this.IDclas.Location = new System.Drawing.Point(64, 59);
            this.IDclas.Name = "IDclas";
            this.IDclas.Size = new System.Drawing.Size(91, 20);
            this.IDclas.TabIndex = 21;
            // 
            // DeleteClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 479);
            this.Controls.Add(this.elimi);
            this.Controls.Add(this.n);
            this.Controls.Add(this.IDclas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteClase";
            this.Text = "DeleteClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button elimi;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox IDclas;
    }
}