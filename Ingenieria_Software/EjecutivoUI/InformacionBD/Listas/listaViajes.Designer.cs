namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    partial class listaViajes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Ingenieria_Software.DataSet1();
            this.vIAJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIAJETableAdapter = new Ingenieria_Software.DataSet1TableAdapters.VIAJETableAdapter();
            this.iDVIAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOSTOALUMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOTOVIAJEDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVIAJEDataGridViewTextBoxColumn,
            this.dESTINODataGridViewTextBoxColumn,
            this.cOSTOALUMNODataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.fOTOVIAJEDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.vIAJEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 299);
            this.dataGridView1.TabIndex = 43;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIAJEBindingSource
            // 
            this.vIAJEBindingSource.DataMember = "VIAJE";
            this.vIAJEBindingSource.DataSource = this.dataSet1;
            // 
            // vIAJETableAdapter
            // 
            this.vIAJETableAdapter.ClearBeforeFill = true;
            // 
            // iDVIAJEDataGridViewTextBoxColumn
            // 
            this.iDVIAJEDataGridViewTextBoxColumn.DataPropertyName = "ID_VIAJE";
            this.iDVIAJEDataGridViewTextBoxColumn.HeaderText = "ID_VIAJE";
            this.iDVIAJEDataGridViewTextBoxColumn.Name = "iDVIAJEDataGridViewTextBoxColumn";
            // 
            // dESTINODataGridViewTextBoxColumn
            // 
            this.dESTINODataGridViewTextBoxColumn.DataPropertyName = "DESTINO";
            this.dESTINODataGridViewTextBoxColumn.HeaderText = "DESTINO";
            this.dESTINODataGridViewTextBoxColumn.Name = "dESTINODataGridViewTextBoxColumn";
            // 
            // cOSTOALUMNODataGridViewTextBoxColumn
            // 
            this.cOSTOALUMNODataGridViewTextBoxColumn.DataPropertyName = "COSTO_ALUMNO";
            this.cOSTOALUMNODataGridViewTextBoxColumn.HeaderText = "COSTO_ALUMNO";
            this.cOSTOALUMNODataGridViewTextBoxColumn.Name = "cOSTOALUMNODataGridViewTextBoxColumn";
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // fOTOVIAJEDataGridViewImageColumn
            // 
            this.fOTOVIAJEDataGridViewImageColumn.DataPropertyName = "FOTO_VIAJE";
            this.fOTOVIAJEDataGridViewImageColumn.HeaderText = "FOTO_VIAJE";
            this.fOTOVIAJEDataGridViewImageColumn.Name = "fOTOVIAJEDataGridViewImageColumn";
            // 
            // listaViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "listaViajes";
            this.Size = new System.Drawing.Size(650, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVIAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOSTOALUMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fOTOVIAJEDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource vIAJEBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.VIAJETableAdapter vIAJETableAdapter;
    }
}
