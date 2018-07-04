namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    partial class listaNoticias
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
            this.nOTICIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOTICIATableAdapter = new Ingenieria_Software.DataSet1TableAdapters.NOTICIATableAdapter();
            this.iDNOTICIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTIPONOTICIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFORMACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOTODataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fECHANOTICIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTICIABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNOTICIADataGridViewTextBoxColumn,
            this.iDTIPONOTICIADataGridViewTextBoxColumn,
            this.iNFORMACIONDataGridViewTextBoxColumn,
            this.fOTODataGridViewImageColumn,
            this.fECHANOTICIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nOTICIABindingSource;
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
            // nOTICIABindingSource
            // 
            this.nOTICIABindingSource.DataMember = "NOTICIA";
            this.nOTICIABindingSource.DataSource = this.dataSet1;
            // 
            // nOTICIATableAdapter
            // 
            this.nOTICIATableAdapter.ClearBeforeFill = true;
            // 
            // iDNOTICIADataGridViewTextBoxColumn
            // 
            this.iDNOTICIADataGridViewTextBoxColumn.DataPropertyName = "ID_NOTICIA";
            this.iDNOTICIADataGridViewTextBoxColumn.HeaderText = "ID_NOTICIA";
            this.iDNOTICIADataGridViewTextBoxColumn.Name = "iDNOTICIADataGridViewTextBoxColumn";
            // 
            // iDTIPONOTICIADataGridViewTextBoxColumn
            // 
            this.iDTIPONOTICIADataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_NOTICIA";
            this.iDTIPONOTICIADataGridViewTextBoxColumn.HeaderText = "ID_TIPO_NOTICIA";
            this.iDTIPONOTICIADataGridViewTextBoxColumn.Name = "iDTIPONOTICIADataGridViewTextBoxColumn";
            // 
            // iNFORMACIONDataGridViewTextBoxColumn
            // 
            this.iNFORMACIONDataGridViewTextBoxColumn.DataPropertyName = "INFORMACION";
            this.iNFORMACIONDataGridViewTextBoxColumn.HeaderText = "INFORMACION";
            this.iNFORMACIONDataGridViewTextBoxColumn.Name = "iNFORMACIONDataGridViewTextBoxColumn";
            // 
            // fOTODataGridViewImageColumn
            // 
            this.fOTODataGridViewImageColumn.DataPropertyName = "FOTO";
            this.fOTODataGridViewImageColumn.HeaderText = "FOTO";
            this.fOTODataGridViewImageColumn.Name = "fOTODataGridViewImageColumn";
            // 
            // fECHANOTICIADataGridViewTextBoxColumn
            // 
            this.fECHANOTICIADataGridViewTextBoxColumn.DataPropertyName = "FECHA_NOTICIA";
            this.fECHANOTICIADataGridViewTextBoxColumn.HeaderText = "FECHA_NOTICIA";
            this.fECHANOTICIADataGridViewTextBoxColumn.Name = "fECHANOTICIADataGridViewTextBoxColumn";
            // 
            // listaNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "listaNoticias";
            this.Size = new System.Drawing.Size(650, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTICIABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNOTICIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPONOTICIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFORMACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fOTODataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHANOTICIADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nOTICIABindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.NOTICIATableAdapter nOTICIATableAdapter;
    }
}
