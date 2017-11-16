namespace GestorDeTiempo
{
    partial class RegistroDeProceso
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
            this.lboxTipoDeUsuario = new System.Windows.Forms.ListBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaDepartamentoParaProcesos = new GestorDeTiempo.TablaDepartamentoParaProcesos();
            this.txtNombreProceso = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.departamentoTableAdapter = new GestorDeTiempo.TablaDepartamentoParaProcesosTableAdapters.DepartamentoTableAdapter();
            this.txtTiempoR = new System.Windows.Forms.TextBox();
            this.txtTiempoNoR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxTipoDeUsuario
            // 
            this.lboxTipoDeUsuario.DataSource = this.departamentoBindingSource;
            this.lboxTipoDeUsuario.DisplayMember = "NombreDepartamento";
            this.lboxTipoDeUsuario.FormattingEnabled = true;
            this.lboxTipoDeUsuario.Location = new System.Drawing.Point(149, 93);
            this.lboxTipoDeUsuario.Name = "lboxTipoDeUsuario";
            this.lboxTipoDeUsuario.Size = new System.Drawing.Size(124, 43);
            this.lboxTipoDeUsuario.TabIndex = 13;
            this.lboxTipoDeUsuario.ValueMember = "IdDepartamento";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.tablaDepartamentoParaProcesos;
            // 
            // tablaDepartamentoParaProcesos
            // 
            this.tablaDepartamentoParaProcesos.DataSetName = "TablaDepartamentoParaProcesos";
            this.tablaDepartamentoParaProcesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombreProceso
            // 
            this.txtNombreProceso.Location = new System.Drawing.Point(149, 26);
            this.txtNombreProceso.Name = "txtNombreProceso";
            this.txtNombreProceso.Size = new System.Drawing.Size(124, 20);
            this.txtNombreProceso.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(665, 93);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 40);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(786, 322);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(665, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(124, 46);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // txtTiempoR
            // 
            this.txtTiempoR.Location = new System.Drawing.Point(111, 52);
            this.txtTiempoR.Name = "txtTiempoR";
            this.txtTiempoR.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoR.TabIndex = 24;
            // 
            // txtTiempoNoR
            // 
            this.txtTiempoNoR.Location = new System.Drawing.Point(218, 52);
            this.txtTiempoNoR.Name = "txtTiempoNoR";
            this.txtTiempoNoR.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoNoR.TabIndex = 25;
            // 
            // RegistroDeProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 476);
            this.Controls.Add(this.txtTiempoNoR);
            this.Controls.Add(this.txtTiempoR);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lboxTipoDeUsuario);
            this.Controls.Add(this.txtNombreProceso);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "RegistroDeProceso";
            this.Text = "RegistroDeProceso";
            this.Load += new System.EventHandler(this.RegistroDeProceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDepartamentoParaProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lboxTipoDeUsuario;
        private System.Windows.Forms.TextBox txtNombreProceso;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegresar;
        private TablaDepartamentoParaProcesos tablaDepartamentoParaProcesos;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private TablaDepartamentoParaProcesosTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.TextBox txtTiempoR;
        private System.Windows.Forms.TextBox txtTiempoNoR;
    }
}