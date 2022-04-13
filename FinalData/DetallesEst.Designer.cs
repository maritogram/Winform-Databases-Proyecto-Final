
namespace FinalData
{
    partial class DetallesEst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datates = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.Visualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datates)).BeginInit();
            this.SuspendLayout();
            // 
            // datates
            // 
            this.datates.AllowUserToAddRows = false;
            this.datates.AllowUserToDeleteRows = false;
            this.datates.AllowUserToResizeColumns = false;
            this.datates.AllowUserToResizeRows = false;
            this.datates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datates.ColumnHeadersHeight = 30;
            this.datates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datates.DefaultCellStyle = dataGridViewCellStyle2;
            this.datates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datates.Enabled = false;
            this.datates.EnableHeadersVisualStyles = false;
            this.datates.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datates.Location = new System.Drawing.Point(11, 11);
            this.datates.Margin = new System.Windows.Forms.Padding(2);
            this.datates.MultiSelect = false;
            this.datates.Name = "datates";
            this.datates.ReadOnly = true;
            this.datates.RowHeadersVisible = false;
            this.datates.RowHeadersWidth = 51;
            this.datates.Size = new System.Drawing.Size(300, 438);
            this.datates.TabIndex = 2;
            this.datates.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(329, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID del estudiante";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(350, 72);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(166, 20);
            this.telefono.TabIndex = 12;
            this.telefono.TextChanged += new System.EventHandler(this.telefono_TextChanged);
            // 
            // Visualizar
            // 
            this.Visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.Visualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Visualizar.Location = new System.Drawing.Point(354, 112);
            this.Visualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(158, 43);
            this.Visualizar.TabIndex = 14;
            this.Visualizar.Text = "Visualizar";
            this.Visualizar.UseVisualStyleBackColor = false;
            this.Visualizar.Click += new System.EventHandler(this.Visualizar_Click);
            // 
            // DetallesEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Visualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.datates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetallesEst";
            this.Text = "DetallesEst";
            this.Load += new System.EventHandler(this.DetallesEst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Button Visualizar;
    }
}