namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    partial class listaAportes
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Ingenieria_Software.DataSet1();
            this.aPORTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPORTETableAdapter = new Ingenieria_Software.DataSet1TableAdapters.APORTETableAdapter();
            this.iDCONTRATODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPORUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAAPORTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPORTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 306);
            this.dataGridView1.TabIndex = 42;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCONTRATODataGridViewTextBoxColumn,
            this.mONTODataGridViewTextBoxColumn,
            this.iDAPORTEDataGridViewTextBoxColumn,
            this.aPORUNDataGridViewTextBoxColumn,
            this.fECHAAPORTEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.aPORTEBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(656, 306);
            this.dataGridView2.TabIndex = 43;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPORTEBindingSource
            // 
            this.aPORTEBindingSource.DataMember = "APORTE";
            this.aPORTEBindingSource.DataSource = this.dataSet1;
            // 
            // aPORTETableAdapter
            // 
            this.aPORTETableAdapter.ClearBeforeFill = true;
            // 
            // iDCONTRATODataGridViewTextBoxColumn
            // 
            this.iDCONTRATODataGridViewTextBoxColumn.DataPropertyName = "ID_CONTRATO";
            this.iDCONTRATODataGridViewTextBoxColumn.HeaderText = "ID_CONTRATO";
            this.iDCONTRATODataGridViewTextBoxColumn.Name = "iDCONTRATODataGridViewTextBoxColumn";
            // 
            // mONTODataGridViewTextBoxColumn
            // 
            this.mONTODataGridViewTextBoxColumn.DataPropertyName = "MONTO";
            this.mONTODataGridViewTextBoxColumn.HeaderText = "MONTO";
            this.mONTODataGridViewTextBoxColumn.Name = "mONTODataGridViewTextBoxColumn";
            // 
            // iDAPORTEDataGridViewTextBoxColumn
            // 
            this.iDAPORTEDataGridViewTextBoxColumn.DataPropertyName = "ID_APORTE";
            this.iDAPORTEDataGridViewTextBoxColumn.HeaderText = "ID_APORTE";
            this.iDAPORTEDataGridViewTextBoxColumn.Name = "iDAPORTEDataGridViewTextBoxColumn";
            // 
            // aPORUNDataGridViewTextBoxColumn
            // 
            this.aPORUNDataGridViewTextBoxColumn.DataPropertyName = "APO_RUN";
            this.aPORUNDataGridViewTextBoxColumn.HeaderText = "APO_RUN";
            this.aPORUNDataGridViewTextBoxColumn.Name = "aPORUNDataGridViewTextBoxColumn";
            // 
            // fECHAAPORTEDataGridViewTextBoxColumn
            // 
            this.fECHAAPORTEDataGridViewTextBoxColumn.DataPropertyName = "FECHA_APORTE";
            this.fECHAAPORTEDataGridViewTextBoxColumn.HeaderText = "FECHA_APORTE";
            this.fECHAAPORTEDataGridViewTextBoxColumn.Name = "fECHAAPORTEDataGridViewTextBoxColumn";
            // 
            // listaAportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listaAportes";
            this.Size = new System.Drawing.Size(656, 306);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPORTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCONTRATODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPORUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAAPORTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aPORTEBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.APORTETableAdapter aPORTETableAdapter;
    }
}
