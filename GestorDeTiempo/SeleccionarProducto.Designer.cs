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
            this.productoDepartamentoProcesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorTiempoDataSet5 = new GestorDeTiempo.GestorTiempoDataSet5();
            this.estadoDeProcesoTableAdapter = new GestorDeTiempo.GestorTiempoDataSet2TableAdapters.EstadoDeProcesoTableAdapter();
            this.gestorTiempoDataSet4 = new GestorDeTiempo.GestorTiempoDataSet4();
            this.gestorTiempoDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorTiempoDataSet41 = new GestorDeTiempo.GestorTiempoDataSet4();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter1 = new GestorDeTiempo.GestorTiempoDataSet4TableAdapters.ProductoTableAdapter();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.productoDepartamentoProcesoTableAdapter = new GestorDeTiempo.GestorTiempoDataSet5TableAdapters.ProductoDepartamentoProcesoTableAdapter();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdDepartamento = new System.Windows.Forms.TextBox();
            this.txtIdProceso = new System.Windows.Forms.TextBox();
            this.txtIdProductoDepartamento = new System.Windows.Forms.TextBox();
            this.txtIdEstado = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEnTime = new System.Windows.Forms.TextBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estadoDeProcesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDepartamentoProcesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet5)).BeginInit();
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
            this.listBox1.Location = new System.Drawing.Point(1, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 69);
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
            this.btnComenzarProduccion.Location = new System.Drawing.Point(98, 2);
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
            this.btnRegresar.Location = new System.Drawing.Point(658, 2);
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 113);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 301);
            this.dataGridView1.TabIndex = 4;
            // 
            // productoDepartamentoProcesoBindingSource
            // 
            this.productoDepartamentoProcesoBindingSource.DataMember = "ProductoDepartamentoProceso";
            this.productoDepartamentoProcesoBindingSource.DataSource = this.gestorTiempoDataSet5;
            // 
            // gestorTiempoDataSet5
            // 
            this.gestorTiempoDataSet5.DataSetName = "GestorTiempoDataSet5";
            this.gestorTiempoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnFinalizar.Location = new System.Drawing.Point(180, 1);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // productoDepartamentoProcesoTableAdapter
            // 
            this.productoDepartamentoProcesoTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(2, 83);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(90, 20);
            this.txtIdProducto.TabIndex = 6;
            // 
            // txtIdDepartamento
            // 
            this.txtIdDepartamento.Enabled = false;
            this.txtIdDepartamento.Location = new System.Drawing.Point(98, 83);
            this.txtIdDepartamento.Name = "txtIdDepartamento";
            this.txtIdDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtIdDepartamento.TabIndex = 7;
            // 
            // txtIdProceso
            // 
            this.txtIdProceso.Enabled = false;
            this.txtIdProceso.Location = new System.Drawing.Point(204, 83);
            this.txtIdProceso.Name = "txtIdProceso";
            this.txtIdProceso.Size = new System.Drawing.Size(100, 20);
            this.txtIdProceso.TabIndex = 8;
            // 
            // txtIdProductoDepartamento
            // 
            this.txtIdProductoDepartamento.Enabled = false;
            this.txtIdProductoDepartamento.Location = new System.Drawing.Point(310, 83);
            this.txtIdProductoDepartamento.Name = "txtIdProductoDepartamento";
            this.txtIdProductoDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductoDepartamento.TabIndex = 9;
            // 
            // txtIdEstado
            // 
            this.txtIdEstado.Enabled = false;
            this.txtIdEstado.Location = new System.Drawing.Point(416, 83);
            this.txtIdEstado.Name = "txtIdEstado";
            this.txtIdEstado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEstado.TabIndex = 10;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(523, 82);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 11;
            // 
            // txtEnTime
            // 
            this.txtEnTime.Enabled = false;
            this.txtEnTime.Location = new System.Drawing.Point(630, 82);
            this.txtEnTime.Name = "txtEnTime";
            this.txtEnTime.Size = new System.Drawing.Size(100, 20);
            this.txtEnTime.TabIndex = 12;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(261, 1);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 13;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // SeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 415);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.txtEnTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtIdEstado);
            this.Controls.Add(this.txtIdProductoDepartamento);
            this.Controls.Add(this.txtIdProceso);
            this.Controls.Add(this.txtIdDepartamento);
            this.Controls.Add(this.txtIdProducto);
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
            ((System.ComponentModel.ISupportInitialize)(this.productoDepartamentoProcesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorTiempoDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GestorTiempoDataSet5 gestorTiempoDataSet5;
        private System.Windows.Forms.BindingSource productoDepartamentoProcesoBindingSource;
        private GestorTiempoDataSet5TableAdapters.ProductoDepartamentoProcesoTableAdapter productoDepartamentoProcesoTableAdapter;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdDepartamento;
        private System.Windows.Forms.TextBox txtIdProceso;
        private System.Windows.Forms.TextBox txtIdProductoDepartamento;
        private System.Windows.Forms.TextBox txtIdEstado;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEnTime;
        private System.Windows.Forms.Button btnDetalle;
    }
}