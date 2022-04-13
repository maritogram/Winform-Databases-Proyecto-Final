
namespace FinalData
{
    partial class Clases
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clasesDataGridView = new System.Windows.Forms.DataGridView();
            this.clasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalDataSet = new FinalData.GeneralDataSet();
            this.tableAdapterManager = new FinalData.GeneralDataSetTableAdapters.TableAdapterManager();
            this.clasesTableAdapter = new FinalData.GeneralDataSetTableAdapters.ClasesTableAdapter();
            this.códigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clasesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clasesDataGridView
            // 
            this.clasesDataGridView.AllowUserToAddRows = false;
            this.clasesDataGridView.AllowUserToDeleteRows = false;
            this.clasesDataGridView.AllowUserToResizeColumns = false;
            this.clasesDataGridView.AllowUserToResizeRows = false;
            this.clasesDataGridView.AutoGenerateColumns = false;
            this.clasesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clasesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clasesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.clasesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clasesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(51)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clasesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clasesDataGridView.ColumnHeadersHeight = 30;
            this.clasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clasesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDataGridViewTextBoxColumn,
            this.asignaturaDataGridViewTextBoxColumn,
            this.crDataGridViewTextBoxColumn,
            this.lunDataGridViewTextBoxColumn,
            this.maDataGridViewTextBoxColumn,
            this.miDataGridViewTextBoxColumn,
            this.juDataGridViewTextBoxColumn,
            this.viDataGridViewTextBoxColumn,
            this.saDataGridViewTextBoxColumn,
            this.profesorDataGridViewTextBoxColumn});
            this.clasesDataGridView.DataSource = this.clasesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clasesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.clasesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clasesDataGridView.Enabled = false;
            this.clasesDataGridView.EnableHeadersVisualStyles = false;
            this.clasesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clasesDataGridView.Location = new System.Drawing.Point(11, 11);
            this.clasesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.clasesDataGridView.MultiSelect = false;
            this.clasesDataGridView.Name = "clasesDataGridView";
            this.clasesDataGridView.ReadOnly = true;
            this.clasesDataGridView.RowHeadersVisible = false;
            this.clasesDataGridView.RowHeadersWidth = 51;
            this.clasesDataGridView.Size = new System.Drawing.Size(871, 438);
            this.clasesDataGridView.TabIndex = 1;
            this.clasesDataGridView.TabStop = false;
            this.clasesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clasesDataGridView_CellContentClick);
            // 
            // clasesBindingSource
            // 
            this.clasesBindingSource.DataMember = "Clases";
            this.clasesBindingSource.DataSource = this.generalDataSet;
            // 
            // generalDataSet
            // 
            this.generalDataSet.DataSetName = "GeneralDataSet";
            this.generalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClasesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EstudianteClaseTableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalData.GeneralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clasesTableAdapter
            // 
            this.clasesTableAdapter.ClearBeforeFill = true;
            // 
            // códigoDataGridViewTextBoxColumn
            // 
            this.códigoDataGridViewTextBoxColumn.DataPropertyName = "Código";
            this.códigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.códigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.códigoDataGridViewTextBoxColumn.Name = "códigoDataGridViewTextBoxColumn";
            this.códigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.códigoDataGridViewTextBoxColumn.Width = 91;
            // 
            // asignaturaDataGridViewTextBoxColumn
            // 
            this.asignaturaDataGridViewTextBoxColumn.DataPropertyName = "Asignatura";
            this.asignaturaDataGridViewTextBoxColumn.HeaderText = "Asignatura";
            this.asignaturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asignaturaDataGridViewTextBoxColumn.Name = "asignaturaDataGridViewTextBoxColumn";
            this.asignaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.asignaturaDataGridViewTextBoxColumn.Width = 118;
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            this.crDataGridViewTextBoxColumn.ReadOnly = true;
            this.crDataGridViewTextBoxColumn.Width = 53;
            // 
            // lunDataGridViewTextBoxColumn
            // 
            this.lunDataGridViewTextBoxColumn.DataPropertyName = "Lun";
            this.lunDataGridViewTextBoxColumn.HeaderText = "Lun";
            this.lunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lunDataGridViewTextBoxColumn.Name = "lunDataGridViewTextBoxColumn";
            this.lunDataGridViewTextBoxColumn.ReadOnly = true;
            this.lunDataGridViewTextBoxColumn.Width = 63;
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "Ma";
            this.maDataGridViewTextBoxColumn.HeaderText = "Ma";
            this.maDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            this.maDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDataGridViewTextBoxColumn.Width = 60;
            // 
            // miDataGridViewTextBoxColumn
            // 
            this.miDataGridViewTextBoxColumn.DataPropertyName = "Mi";
            this.miDataGridViewTextBoxColumn.HeaderText = "Mi";
            this.miDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.miDataGridViewTextBoxColumn.Name = "miDataGridViewTextBoxColumn";
            this.miDataGridViewTextBoxColumn.ReadOnly = true;
            this.miDataGridViewTextBoxColumn.Width = 55;
            // 
            // juDataGridViewTextBoxColumn
            // 
            this.juDataGridViewTextBoxColumn.DataPropertyName = "Ju";
            this.juDataGridViewTextBoxColumn.HeaderText = "Ju";
            this.juDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juDataGridViewTextBoxColumn.Name = "juDataGridViewTextBoxColumn";
            this.juDataGridViewTextBoxColumn.ReadOnly = true;
            this.juDataGridViewTextBoxColumn.Width = 54;
            // 
            // viDataGridViewTextBoxColumn
            // 
            this.viDataGridViewTextBoxColumn.DataPropertyName = "Vi";
            this.viDataGridViewTextBoxColumn.HeaderText = "Vi";
            this.viDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.viDataGridViewTextBoxColumn.Name = "viDataGridViewTextBoxColumn";
            this.viDataGridViewTextBoxColumn.ReadOnly = true;
            this.viDataGridViewTextBoxColumn.Width = 51;
            // 
            // saDataGridViewTextBoxColumn
            // 
            this.saDataGridViewTextBoxColumn.DataPropertyName = "Sa";
            this.saDataGridViewTextBoxColumn.HeaderText = "Sa";
            this.saDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saDataGridViewTextBoxColumn.Name = "saDataGridViewTextBoxColumn";
            this.saDataGridViewTextBoxColumn.ReadOnly = true;
            this.saDataGridViewTextBoxColumn.Width = 55;
            // 
            // profesorDataGridViewTextBoxColumn
            // 
            this.profesorDataGridViewTextBoxColumn.DataPropertyName = "Profesor";
            this.profesorDataGridViewTextBoxColumn.HeaderText = "Profesor";
            this.profesorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.profesorDataGridViewTextBoxColumn.Name = "profesorDataGridViewTextBoxColumn";
            this.profesorDataGridViewTextBoxColumn.ReadOnly = true;
            this.profesorDataGridViewTextBoxColumn.Width = 103;
            // 
            // Clases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clasesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clases";
            this.Text = "Clases";
            this.Load += new System.EventHandler(this.Clases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clasesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GeneralDataSet generalDataSet;
        private System.Windows.Forms.BindingSource clasesBindingSource;
        private System.Windows.Forms.DataGridView clasesDataGridView;
        private GeneralDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesorDataGridViewTextBoxColumn;
        private GeneralDataSetTableAdapters.ClasesTableAdapter clasesTableAdapter;
    }
}