namespace GestorDeTiempo
{
    partial class ProductoVincularConDepartamento
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
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tablaDepartamentoParaVincularConProducto = new GestorDeTiempo.TablaDepartamentoParaVincularConProducto();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new GestorDeTiempo.TablaDepartamentoParaVincularConProductoTableAdapters.DepartamentoTableAdapter();
            this.tablaProductoParaVincularConDepartamento = new GestorDeTiempo.TablaProductoParaVincularConDepartamento();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new GestorDeTiempo.TablaProductoParaVincularConDepartamentoTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaVincularConProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductoParaVincularConDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.departamentoBindingSource;
            this.comboBox1.DisplayMember = "NombreDepartamento";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdDepartamento";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.productoBindingSource;
            this.comboBox2.DisplayMember = "NombreProducto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "IdProducto";
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(91, 163);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(75, 23);
            this.btnVincular.TabIndex = 2;
            this.btnVincular.Text = "Vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(173, 162);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tablaDepartamentoParaVincularConProducto
            // 
            this.tablaDepartamentoParaVincularConProducto.DataSetName = "TablaDepartamentoParaVincularConProducto";
            this.tablaDepartamentoParaVincularConProducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.tablaDepartamentoParaVincularConProducto;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tablaProductoParaVincularConDepartamento
            // 
            this.tablaProductoParaVincularConDepartamento.DataSetName = "TablaProductoParaVincularConDepartamento";
            this.tablaProductoParaVincularConDepartamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.tablaProductoParaVincularConDepartamento;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // ProductoVincularConDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "ProductoVincularConDepartamento";
            this.Text = "ProductoVincularConDepartamento";
            this.Load += new System.EventHandler(this.ProductoVincularConDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaVincularConProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductoParaVincularConDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnRegresar;
        private TablaDepartamentoParaVincularConProducto tablaDepartamentoParaVincularConProducto;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private TablaDepartamentoParaVincularConProductoTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private TablaProductoParaVincularConDepartamento tablaProductoParaVincularConDepartamento;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private TablaProductoParaVincularConDepartamentoTableAdapters.ProductoTableAdapter productoTableAdapter;
    }
}