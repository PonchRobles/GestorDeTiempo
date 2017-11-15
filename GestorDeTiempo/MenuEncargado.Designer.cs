namespace GestorDeTiempo
{
    partial class MenuEncargado
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
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnRegistroTipoDeUsuario = new System.Windows.Forms.Button();
            this.btnProducirUnProducto = new System.Windows.Forms.Button();
            this.btnCrearPath = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(172, 96);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnRegistroTipoDeUsuario
            // 
            this.btnRegistroTipoDeUsuario.Location = new System.Drawing.Point(190, 11);
            this.btnRegistroTipoDeUsuario.Name = "btnRegistroTipoDeUsuario";
            this.btnRegistroTipoDeUsuario.Size = new System.Drawing.Size(172, 97);
            this.btnRegistroTipoDeUsuario.TabIndex = 1;
            this.btnRegistroTipoDeUsuario.Text = "Registrar tipo de usuario";
            this.btnRegistroTipoDeUsuario.UseVisualStyleBackColor = true;
            this.btnRegistroTipoDeUsuario.Click += new System.EventHandler(this.btnRegistroTipoDeUsuario_Click);
            // 
            // btnProducirUnProducto
            // 
            this.btnProducirUnProducto.Location = new System.Drawing.Point(12, 114);
            this.btnProducirUnProducto.Name = "btnProducirUnProducto";
            this.btnProducirUnProducto.Size = new System.Drawing.Size(172, 96);
            this.btnProducirUnProducto.TabIndex = 2;
            this.btnProducirUnProducto.Text = "Producir Un producto";
            this.btnProducirUnProducto.UseVisualStyleBackColor = true;
            this.btnProducirUnProducto.Click += new System.EventHandler(this.btnProducirUnProducto_Click);
            // 
            // btnCrearPath
            // 
            this.btnCrearPath.Location = new System.Drawing.Point(190, 114);
            this.btnCrearPath.Name = "btnCrearPath";
            this.btnCrearPath.Size = new System.Drawing.Size(172, 96);
            this.btnCrearPath.TabIndex = 3;
            this.btnCrearPath.Text = "CrearPath";
            this.btnCrearPath.UseVisualStyleBackColor = true;
            this.btnCrearPath.Click += new System.EventHandler(this.btnCrearPath_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(13, 217);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(171, 104);
            this.btnGeneral.TabIndex = 4;
            this.btnGeneral.Text = "VistaGral";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // MenuEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 348);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnCrearPath);
            this.Controls.Add(this.btnProducirUnProducto);
            this.Controls.Add(this.btnRegistroTipoDeUsuario);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Name = "MenuEncargado";
            this.Text = "MenuEncargado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnRegistroTipoDeUsuario;
        private System.Windows.Forms.Button btnProducirUnProducto;
        private System.Windows.Forms.Button btnCrearPath;
        private System.Windows.Forms.Button btnGeneral;
    }
}