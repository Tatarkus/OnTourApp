namespace Ingenieria_Software.EjecutivoUI.InformacionBD.Listas
{
    partial class listaAlumnos
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
            this.dgAlumnos = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Ingenieria_Software.DataSet1();
            this.aLUMNOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLUMNOTableAdapter = new Ingenieria_Software.DataSet1TableAdapters.ALUMNOTableAdapter();
            this.rUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPORUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCURSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlumnos
            // 
            this.dgAlumnos.AllowUserToAddRows = false;
            this.dgAlumnos.AllowUserToDeleteRows = false;
            this.dgAlumnos.AutoGenerateColumns = false;
            this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rUNDataGridViewTextBoxColumn,
            this.aPORUNDataGridViewTextBoxColumn,
            this.iDCURSODataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.dVDataGridViewTextBoxColumn,
            this.nOMBRESDataGridViewTextBoxColumn,
            this.aPELLIDOSDataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn});
            this.dgAlumnos.DataSource = this.aLUMNOBindingSource;
            this.dgAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAlumnos.Location = new System.Drawing.Point(0, 0);
            this.dgAlumnos.Name = "dgAlumnos";
            this.dgAlumnos.ReadOnly = true;
            this.dgAlumnos.Size = new System.Drawing.Size(647, 266);
            this.dgAlumnos.TabIndex = 0;
            this.dgAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlumnos_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLUMNOBindingSource
            // 
            this.aLUMNOBindingSource.DataMember = "ALUMNO";
            this.aLUMNOBindingSource.DataSource = this.dataSet1;
            // 
            // aLUMNOTableAdapter
            // 
            this.aLUMNOTableAdapter.ClearBeforeFill = true;
            // 
            // rUNDataGridViewTextBoxColumn
            // 
            this.rUNDataGridViewTextBoxColumn.DataPropertyName = "RUN";
            this.rUNDataGridViewTextBoxColumn.HeaderText = "RUN";
            this.rUNDataGridViewTextBoxColumn.Name = "rUNDataGridViewTextBoxColumn";
            this.rUNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPORUNDataGridViewTextBoxColumn
            // 
            this.aPORUNDataGridViewTextBoxColumn.DataPropertyName = "APO_RUN";
            this.aPORUNDataGridViewTextBoxColumn.HeaderText = "APO_RUN";
            this.aPORUNDataGridViewTextBoxColumn.Name = "aPORUNDataGridViewTextBoxColumn";
            this.aPORUNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCURSODataGridViewTextBoxColumn
            // 
            this.iDCURSODataGridViewTextBoxColumn.DataPropertyName = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.HeaderText = "ID_CURSO";
            this.iDCURSODataGridViewTextBoxColumn.Name = "iDCURSODataGridViewTextBoxColumn";
            this.iDCURSODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dVDataGridViewTextBoxColumn
            // 
            this.dVDataGridViewTextBoxColumn.DataPropertyName = "DV";
            this.dVDataGridViewTextBoxColumn.HeaderText = "DV";
            this.dVDataGridViewTextBoxColumn.Name = "dVDataGridViewTextBoxColumn";
            this.dVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            this.nOMBRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELLIDOSDataGridViewTextBoxColumn
            // 
            this.aPELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.Name = "aPELLIDOSDataGridViewTextBoxColumn";
            this.aPELLIDOSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            this.cORREODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listaAlumnos
            // 
            this.Controls.Add(this.dgAlumnos);
            this.Name = "listaAlumnos";
            this.Size = new System.Drawing.Size(647, 266);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView dgAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPORUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCURSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aLUMNOBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ALUMNOTableAdapter aLUMNOTableAdapter;
    }


 }
