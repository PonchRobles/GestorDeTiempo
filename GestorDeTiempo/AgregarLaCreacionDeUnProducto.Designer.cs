namespace GestorDeTiempo
{
    partial class AgregarLaCreacionDeUnProducto
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
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorTiempoDataSet1 = new GestorDeTiempo.GestorTiempoDataSet1();
            this.productoTableAdapter = new GestorDeTiempo.GestorTiempoDataSet1TableAdapters.ProductoTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectedDepartamento = new GestorDeTiempo.SelectedDepartamento();
            this.departamentoTableAdapter = new GestorDeTiempo.SelectedDepartamentoTableAdapters.DepartamentoTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.procesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorTiempoDataSet3 = new GestorDeTiempo.GestorTiempoDataSet3();
            this.procesoTableAdapter = new GestorDeTiempo.GestorTiempoDataSet3TableAdapters.ProcesoTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tablaProcesoModificadaEnTime = new GestorDeTiempo.TablaProcesoModificadaEnTime();
            this.procesoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.procesoTableAdapter1 = new GestorDeTiempo.TablaProcesoModificadaEnTimeTableAdapters.ProcesoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcesoModificadaEnTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productoBindingSource;
            this.comboBox1.DisplayMember = "NombreProducto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.gestorTiempoDataSet1;
            // 
            // gestorTiempoDataSet1
            // 
            this.gestorTiempoDataSet1.DataSetName = "GestorTiempoDataSet1";
            this.gestorTiempoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.departamentoBindingSource;
            this.comboBox2.DisplayMember = "NombreDepartamento";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "IdDepartamento";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.selectedDepartamento;
            // 
            // selectedDepartamento
            // 
            this.selectedDepartamento.DataSetName = "SelectedDepartamento";
            this.selectedDepartamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.procesoBindingSource1;
            this.comboBox3.DisplayMember = "NombreProceso";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "IdProceso";
            // 
            // procesoBindingSource
            // 
            this.procesoBindingSource.DataMember = "Proceso";
            this.procesoBindingSource.DataSource = this.gestorTiempoDataSet3;
            // 
            // gestorTiempoDataSet3
            // 
            this.gestorTiempoDataSet3.DataSetName = "GestorTiempoDataSet3";
            this.gestorTiempoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procesoTableAdapter
            // 
            this.procesoTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(142, 143);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(113, 44);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(279, 143);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 44);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tablaProcesoModificadaEnTime
            // 
            this.tablaProcesoModificadaEnTime.DataSetName = "TablaProcesoModificadaEnTime";
            this.tablaProcesoModificadaEnTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procesoBindingSource1
            // 
            this.procesoBindingSource1.DataMember = "Proceso";
            this.procesoBindingSource1.DataSource = this.tablaProcesoModificadaEnTime;
            // 
            // procesoTableAdapter1
            // 
            this.procesoTableAdapter1.ClearBeforeFill = true;
            // 
            // AgregarLaCreacionDeUnProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 199);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "AgregarLaCreacionDeUnProducto";
            this.Text = "AgregarLaCreacionDeUnProducto";
            this.Load += new System.EventHandler(this.AgregarLaCreacionDeUnProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcesoModificadaEnTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private GestorTiempoDataSet1 gestorTiempoDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private GestorTiempoDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private SelectedDepartamento selectedDepartamento;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private SelectedDepartamentoTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private GestorTiempoDataSet3 gestorTiempoDataSet3;
        private System.Windows.Forms.BindingSource procesoBindingSource;
        private GestorTiempoDataSet3TableAdapters.ProcesoTableAdapter procesoTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRegresar;
        private TablaProcesoModificadaEnTime tablaProcesoModificadaEnTime;
        private System.Windows.Forms.BindingSource procesoBindingSource1;
        private TablaProcesoModificadaEnTimeTableAdapters.ProcesoTableAdapter procesoTableAdapter1;
    }
}