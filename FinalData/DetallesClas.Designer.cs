
namespace FinalData
{
    partial class DetallesClas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Visualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clasecode = new System.Windows.Forms.TextBox();
            this.datacla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datacla)).BeginInit();
            this.SuspendLayout();
            // 
            // Visualizar
            // 
            this.Visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.Visualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizar.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Visualizar.Location = new System.Drawing.Point(45, 108);
            this.Visualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(211, 52);
            this.Visualizar.TabIndex = 17;
            this.Visualizar.Text = "Visualizar";
            this.Visualizar.UseVisualStyleBackColor = false;
            this.Visualizar.Click += new System.EventHandler(this.Visualizar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Código de la clase";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clasecode
            // 
            this.clasecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.clasecode.Location = new System.Drawing.Point(40, 58);
            this.clasecode.Margin = new System.Windows.Forms.Padding(4);
            this.clasecode.Name = "clasecode";
            this.clasecode.Size = new System.Drawing.Size(220, 22);
            this.clasecode.TabIndex = 15;
            // 
            // datacla
            // 
            this.datacla.AllowUserToAddRows = false;
            this.datacla.AllowUserToDeleteRows = false;
            this.datacla.AllowUserToResizeColumns = false;
            this.datacla.AllowUserToResizeRows = false;
            this.datacla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datacla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datacla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datacla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datacla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datacla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datacla.ColumnHeadersHeight = 30;
            this.datacla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datacla.DefaultCellStyle = dataGridViewCellStyle6;
            this.datacla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datacla.Enabled = false;
            this.datacla.EnableHeadersVisualStyles = false;
            this.datacla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datacla.Location = new System.Drawing.Point(16, 194);
            this.datacla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datacla.MultiSelect = false;
            this.datacla.Name = "datacla";
            this.datacla.ReadOnly = true;
            this.datacla.RowHeadersVisible = false;
            this.datacla.RowHeadersWidth = 51;
            this.datacla.Size = new System.Drawing.Size(1436, 539);
            this.datacla.TabIndex = 18;
            this.datacla.TabStop = false;
            // 
            // DetallesClas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 529);
            this.Controls.Add(this.datacla);
            this.Controls.Add(this.Visualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clasecode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetallesClas";
            this.Text = "DetallesClas";
            ((System.ComponentModel.ISupportInitialize)(this.datacla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Visualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clasecode;
        private System.Windows.Forms.DataGridView datacla;
    }
}