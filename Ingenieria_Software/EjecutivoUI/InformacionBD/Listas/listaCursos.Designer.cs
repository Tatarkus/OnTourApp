namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    partial class listaCursos
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
            this.cURSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURSOTableAdapter = new Ingenieria_Software.DataSet1TableAdapters.CURSOTableAdapter();
            this.iDCOLEGIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lETRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCURSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCOLEGIODataGridViewTextBoxColumn,
            this.nUMERODataGridViewTextBoxColumn,
            this.lETRADataGridViewTextBoxColumn,
            this.iDCURSODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cURSOBindingSource;
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
            // cURSOBindingSource
            // 
            this.cURSOBindingSource.DataMember = "CURSO";
            this.cURSOBindingSource.DataSource = this.dataSet1;
            // 
            // cURSOTableAdapter
            // 
            this.cURSOTableAdapter.ClearBeforeFill = true;
            // 
            // iDCOLEGIODataGridViewTextBoxColumn
            // 
            this.iDCOLEGIODataGridViewTextBoxColumn.DataPropertyName = "ID_COLEGIO";
            this.iDCOLEGIODataGridViewTextBoxColumn.HeaderText = "ID_COLEGIO";
            this.iDCOLEGIODataGridViewTextBoxColumn.Name = "iDCOLEGIODataGridViewTextBoxColumn";
            // 
            // nUMERODataGridViewTextBoxColumn
            // 
            this.nUMERODataGridViewTextBoxColumn.DataPropertyName = "NUMERO";
            this.nUMERODataGridViewTextBoxColumn.HeaderText = "NUMERO";
            this.nUMERODataGridViewTextBoxColumn.Name = "nUMERODataGridViewTextBoxColumn";
            // 
            // lETRADataGridViewTextBoxColumn
            // 
            this.lETRADataGridViewTextBoxColumn.DataPropertyName = "LETRA";
            this.lETRADataGridViewTextBoxColumn.HeaderText = "LETRA";
            this.lETRADataGridViewTextBoxColumn.Name = "lETRADataGridViewTextBoxColumn";
            // 
            // iDCURSODataGridViewTextBoxColumn
            // 
            this.iDCURSODataGridViewTextBoxColumn.DataPropertyName = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.HeaderText = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.Name = "iDCURSODataGridViewTextBoxColumn";
            // 
            // listaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "listaCursos";
            this.Size = new System.Drawing.Size(650, 299);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cURSOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOLEGIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lETRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCURSODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cURSOBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.CURSOTableAdapter cURSOTableAdapter;
    }
}
