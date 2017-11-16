namespace GestorDeTiempo
{
    partial class WorkStationVincularConDepartamento
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tablaWorkStation = new GestorDeTiempo.TablaWorkStation();
            this.workStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workStationTableAdapter = new GestorDeTiempo.TablaWorkStationTableAdapters.WorkStationTableAdapter();
            this.tablaDepartamentoParaProcesos = new GestorDeTiempo.TablaDepartamentoParaProcesos();
            this.tablaDepartamentoParaProcesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaDepartamento = new GestorDeTiempo.TablaDepartamento();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new GestorDeTiempo.TablaDepartamentoTableAdapters.DepartamentoTableAdapter();
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaWorkStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workStationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaProcesosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.workStationBindingSource;
            this.comboBox1.DisplayMember = "NombreWorkStation";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdWorkStation";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.departamentoBindingSource;
            this.comboBox2.DisplayMember = "NombreDepartamento";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "IdDepartamento";
            // 
            // tablaWorkStation
            // 
            this.tablaWorkStation.DataSetName = "TablaWorkStation";
            this.tablaWorkStation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workStationBindingSource
            // 
            this.workStationBindingSource.DataMember = "WorkStation";
            this.workStationBindingSource.DataSource = this.tablaWorkStation;
            // 
            // workStationTableAdapter
            // 
            this.workStationTableAdapter.ClearBeforeFill = true;
            // 
            // tablaDepartamentoParaProcesos
            // 
            this.tablaDepartamentoParaProcesos.DataSetName = "TablaDepartamentoParaProcesos";
            this.tablaDepartamentoParaProcesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablaDepartamentoParaProcesosBindingSource
            // 
            this.tablaDepartamentoParaProcesosBindingSource.DataSource = this.tablaDepartamentoParaProcesos;
            this.tablaDepartamentoParaProcesosBindingSource.Position = 0;
            // 
            // tablaDepartamento
            // 
            this.tablaDepartamento.DataSetName = "TablaDepartamento";
            this.tablaDepartamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.tablaDepartamento;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(103, 148);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(75, 23);
            this.btnVincular.TabIndex = 2;
            this.btnVincular.Text = "vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(185, 147);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // WorkStationVincularConDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "WorkStationVincularConDepartamento";
            this.Text = "WorkStationVincularConDepartamento";
            this.Load += new System.EventHandler(this.WorkStationVincularConDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaWorkStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workStationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaProcesosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private TablaWorkStation tablaWorkStation;
        private System.Windows.Forms.BindingSource workStationBindingSource;
        private TablaWorkStationTableAdapters.WorkStationTableAdapter workStationTableAdapter;
        private System.Windows.Forms.BindingSource tablaDepartamentoParaProcesosBindingSource;
        private TablaDepartamentoParaProcesos tablaDepartamentoParaProcesos;
        private TablaDepartamento tablaDepartamento;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private TablaDepartamentoTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnRegresar;
    }
}