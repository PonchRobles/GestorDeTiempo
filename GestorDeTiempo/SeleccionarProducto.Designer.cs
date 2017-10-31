namespace GestorDeTiempo
{
    partial class SeleccionarProducto
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.estadoDeProcesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorTiempoDataSet2 = new GestorDeTiempo.GestorTiempoDataSet2();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorTiempoDataSet1 = new GestorDeTiempo.GestorTiempoDataSet1();
            this.btnComenzarProduccion = new System.Windows.Forms.Button();
            this.productoTableAdapter = new GestorDeTiempo.GestorTiempoDataSet1TableAdapters.ProductoTableAdapter();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estadoDeProcesoTableAdapter = new GestorDeTiempo.GestorTiempoDataSet2TableAdapters.EstadoDeProcesoTableAdapter();
            this.gestorTiempoDataSet4 = new GestorDeTiempo.GestorTiempoDataSet4();
            this.gestorTiempoDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorTiempoDataSet41 = new GestorDeTiempo.GestorTiempoDataSet4();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter1 = new GestorDeTiempo.GestorTiempoDataSet4TableAdapters.ProductoTableAdapter();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estadoDeProcesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.estadoDeProcesoBindingSource;
            this.listBox1.DisplayMember = "NombreEstadoProceso";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "IdEstadoDeProceso";
            // 
            // estadoDeProcesoBindingSource
            // 
            this.estadoDeProcesoBindingSource.DataMember = "EstadoDeProceso";
            this.estadoDeProcesoBindingSource.DataSource = this.gestorTiempoDataSet2;
            // 
            // gestorTiempoDataSet2
            // 
            this.gestorTiempoDataSet2.DataSetName = "GestorTiempoDataSet2";
            this.gestorTiempoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnComenzarProduccion
            // 
            this.btnComenzarProduccion.Location = new System.Drawing.Point(12, 350);
            this.btnComenzarProduccion.Name = "btnComenzarProduccion";
            this.btnComenzarProduccion.Size = new System.Drawing.Size(75, 23);
            this.btnComenzarProduccion.TabIndex = 2;
            this.btnComenzarProduccion.Text = "Comenzar Produccion";
            this.btnComenzarProduccion.UseVisualStyleBackColor = true;
            this.btnComenzarProduccion.Click += new System.EventHandler(this.btnComenzarProduccion_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 380);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 265);
            this.dataGridView1.TabIndex = 4;
            // 
            // estadoDeProcesoTableAdapter
            // 
            this.estadoDeProcesoTableAdapter.ClearBeforeFill = true;
            // 
            // gestorTiempoDataSet4
            // 
            this.gestorTiempoDataSet4.DataSetName = "GestorTiempoDataSet4";
            this.gestorTiempoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestorTiempoDataSet4BindingSource
            // 
            this.gestorTiempoDataSet4BindingSource.DataSource = this.gestorTiempoDataSet4;
            this.gestorTiempoDataSet4BindingSource.Position = 0;
            // 
            // gestorTiempoDataSet41
            // 
            this.gestorTiempoDataSet41.DataSetName = "GestorTiempoDataSet4";
            this.gestorTiempoDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.gestorTiempoDataSet4BindingSource;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(13, 321);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // SeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 415);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnComenzarProduccion);
            this.Controls.Add(this.listBox1);
            this.Name = "SeleccionarProducto";
            this.Text = "SeleccionarProducto";
            this.Load += new System.EventHandler(this.SeleccionarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadoDeProcesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnComenzarProduccion;
        private GestorTiempoDataSet1 gestorTiempoDataSet1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private GestorTiempoDataSet1TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GestorTiempoDataSet2 gestorTiempoDataSet2;
        private System.Windows.Forms.BindingSource estadoDeProcesoBindingSource;
        private GestorTiempoDataSet2TableAdapters.EstadoDeProcesoTableAdapter estadoDeProcesoTableAdapter;
        private System.Windows.Forms.BindingSource gestorTiempoDataSet4BindingSource;
        private GestorTiempoDataSet4 gestorTiempoDataSet4;
        private GestorTiempoDataSet4 gestorTiempoDataSet41;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private GestorTiempoDataSet4TableAdapters.ProductoTableAdapter productoTableAdapter1;
        private System.Windows.Forms.Button btnFinalizar;
    }
}