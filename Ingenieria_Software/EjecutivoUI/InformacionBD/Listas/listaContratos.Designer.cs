namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    partial class listaContratos
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
            this.cONTRATOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cONTRATOTableAdapter = new Ingenieria_Software.DataSet1TableAdapters.CONTRATOTableAdapter();
            this.iDVIAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCONTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSEGURODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCURSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eJERUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPORUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAVIAJEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVIAJEDataGridViewTextBoxColumn,
            this.iDCONTRATODataGridViewTextBoxColumn,
            this.iDSEGURODataGridViewTextBoxColumn,
            this.iDCURSODataGridViewTextBoxColumn,
            this.eJERUNDataGridViewTextBoxColumn,
            this.aPORUNDataGridViewTextBoxColumn,
            this.fECHAINICIODataGridViewTextBoxColumn,
            this.fECHAVIAJEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cONTRATOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(650, 299);
            this.dataGridView1.TabIndex = 43;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cONTRATOBindingSource
            // 
            this.cONTRATOBindingSource.DataMember = "CONTRATO";
            this.cONTRATOBindingSource.DataSource = this.dataSet1;
            // 
            // cONTRATOTableAdapter
            // 
            this.cONTRATOTableAdapter.ClearBeforeFill = true;
            // 
            // iDVIAJEDataGridViewTextBoxColumn
            // 
            this.iDVIAJEDataGridViewTextBoxColumn.DataPropertyName = "ID_VIAJE";
            this.iDVIAJEDataGridViewTextBoxColumn.HeaderText = "ID_VIAJE";
            this.iDVIAJEDataGridViewTextBoxColumn.Name = "iDVIAJEDataGridViewTextBoxColumn";
            this.iDVIAJEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCONTRATODataGridViewTextBoxColumn
            // 
            this.iDCONTRATODataGridViewTextBoxColumn.DataPropertyName = "ID_CONTRATO";
            this.iDCONTRATODataGridViewTextBoxColumn.HeaderText = "ID_CONTRATO";
            this.iDCONTRATODataGridViewTextBoxColumn.Name = "iDCONTRATODataGridViewTextBoxColumn";
            this.iDCONTRATODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDSEGURODataGridViewTextBoxColumn
            // 
            this.iDSEGURODataGridViewTextBoxColumn.DataPropertyName = "ID_SEGURO";
            this.iDSEGURODataGridViewTextBoxColumn.HeaderText = "ID_SEGURO";
            this.iDSEGURODataGridViewTextBoxColumn.Name = "iDSEGURODataGridViewTextBoxColumn";
            this.iDSEGURODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCURSODataGridViewTextBoxColumn
            // 
            this.iDCURSODataGridViewTextBoxColumn.DataPropertyName = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.HeaderText = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.Name = "iDCURSODataGridViewTextBoxColumn";
            this.iDCURSODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eJERUNDataGridViewTextBoxColumn
            // 
            this.eJERUNDataGridViewTextBoxColumn.DataPropertyName = "EJE_RUN";
            this.eJERUNDataGridViewTextBoxColumn.HeaderText = "EJE_RUN";
            this.eJERUNDataGridViewTextBoxColumn.Name = "eJERUNDataGridViewTextBoxColumn";
            this.eJERUNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPORUNDataGridViewTextBoxColumn
            // 
            this.aPORUNDataGridViewTextBoxColumn.DataPropertyName = "APO_RUN";
            this.aPORUNDataGridViewTextBoxColumn.HeaderText = "APO_RUN";
            this.aPORUNDataGridViewTextBoxColumn.Name = "aPORUNDataGridViewTextBoxColumn";
            this.aPORUNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAINICIODataGridViewTextBoxColumn
            // 
            this.fECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.HeaderText = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.Name = "fECHAINICIODataGridViewTextBoxColumn";
            this.fECHAINICIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAVIAJEDataGridViewTextBoxColumn
            // 
            this.fECHAVIAJEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_VIAJE";
            this.fECHAVIAJEDataGridViewTextBoxColumn.HeaderText = "FECHA_VIAJE";
            this.fECHAVIAJEDataGridViewTextBoxColumn.Name = "fECHAVIAJEDataGridViewTextBoxColumn";
            this.fECHAVIAJEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listaContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "listaContratos";
            this.Size = new System.Drawing.Size(650, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONTRATOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVIAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCONTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSEGURODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCURSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eJERUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPORUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVIAJEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cONTRATOBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CONTRATOTableAdapter cONTRATOTableAdapter;
    }
}
