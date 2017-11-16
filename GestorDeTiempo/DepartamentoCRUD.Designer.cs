namespace GestorDeTiempo
{
    partial class DepartamentoCRUD
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
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.btnCrearDep = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablaUsuariosParaCrearDepartamento = new GestorDeTiempo.TablaUsuariosParaCrearDepartamento();
            this.usuariosTableAdapter = new GestorDeTiempo.TablaUsuariosParaCrearDepartamentoTableAdapters.UsuariosTableAdapter();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuariosParaCrearDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(39, 131);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(156, 20);
            this.txtNombreDepartamento.TabIndex = 0;
            this.txtNombreDepartamento.TextChanged += new System.EventHandler(this.txtNombreDepartamento_TextChanged);
            // 
            // btnCrearDep
            // 
            this.btnCrearDep.Location = new System.Drawing.Point(75, 157);
            this.btnCrearDep.Name = "btnCrearDep";
            this.btnCrearDep.Size = new System.Drawing.Size(75, 23);
            this.btnCrearDep.TabIndex = 1;
            this.btnCrearDep.Text = "Crear";
            this.btnCrearDep.UseVisualStyleBackColor = true;
            this.btnCrearDep.Click += new System.EventHandler(this.btnCrearDep_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.usuariosBindingSource;
            this.listBox1.DisplayMember = "NombreDeUsuario";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(59, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "IdUsuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.tablaUsuariosParaCrearDepartamento;
            // 
            // tablaUsuariosParaCrearDepartamento
            // 
            this.tablaUsuariosParaCrearDepartamento.DataSetName = "TablaUsuariosParaCrearDepartamento";
            this.tablaUsuariosParaCrearDepartamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(156, 157);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // DepartamentoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 207);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCrearDep);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Name = "DepartamentoCRUD";
            this.Text = "DepartamentoCRUD";
            this.Load += new System.EventHandler(this.DepartamentoCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuariosParaCrearDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Button btnCrearDep;
        private System.Windows.Forms.ListBox listBox1;
        private TablaUsuariosParaCrearDepartamento tablaUsuariosParaCrearDepartamento;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private TablaUsuariosParaCrearDepartamentoTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button btnRegresar;
    }
}