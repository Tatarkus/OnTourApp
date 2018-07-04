namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    partial class listaSeguros   {
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
            this.sEGUROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEGUROTableAdapter = new Ingenieria_Software.DataSet1TableAdapters.SEGUROTableAdapter();
            this.iDSEGURODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESEGURODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIOALUMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGUROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSEGURODataGridViewTextBoxColumn,
            this.nOMBRESEGURODataGridViewTextBoxColumn,
            this.pRECIOALUMNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sEGUROBindingSource;
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
            // sEGUROBindingSource
            // 
            this.sEGUROBindingSource.DataMember = "SEGURO";
            this.sEGUROBindingSource.DataSource = this.dataSet1;
            // 
            // sEGUROTableAdapter
            // 
            this.sEGUROTableAdapter.ClearBeforeFill = true;
            // 
            // iDSEGURODataGridViewTextBoxColumn
            // 
            this.iDSEGURODataGridViewTextBoxColumn.DataPropertyName = "ID_SEGURO";
            this.iDSEGURODataGridViewTextBoxColumn.HeaderText = "ID_SEGURO";
            this.iDSEGURODataGridViewTextBoxColumn.Name = "iDSEGURODataGridViewTextBoxColumn";
            // 
            // nOMBRESEGURODataGridViewTextBoxColumn
            // 
            this.nOMBRESEGURODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_SEGURO";
            this.nOMBRESEGURODataGridViewTextBoxColumn.HeaderText = "NOMBRE_SEGURO";
            this.nOMBRESEGURODataGridViewTextBoxColumn.Name = "nOMBRESEGURODataGridViewTextBoxColumn";
            // 
            // pRECIOALUMNODataGridViewTextBoxColumn
            // 
            this.pRECIOALUMNODataGridViewTextBoxColumn.DataPropertyName = "PRECIO_ALUMNO";
            this.pRECIOALUMNODataGridViewTextBoxColumn.HeaderText = "PRECIO_ALUMNO";
            this.pRECIOALUMNODataGridViewTextBoxColumn.Name = "pRECIOALUMNODataGridViewTextBoxColumn";
            // 
            // listaSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "listaSeguros";
            this.Size = new System.Drawing.Size(650, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEGUROBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSEGURODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESEGURODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIOALUMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sEGUROBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.SEGUROTableAdapter sEGUROTableAdapter;
    }
}
