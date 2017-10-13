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
            this.SuspendLayout();
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(32, 39);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(172, 96);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "Registrar Usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnRegistroTipoDeUsuario
            // 
            this.btnRegistroTipoDeUsuario.Location = new System.Drawing.Point(256, 38);
            this.btnRegistroTipoDeUsuario.Name = "btnRegistroTipoDeUsuario";
            this.btnRegistroTipoDeUsuario.Size = new System.Drawing.Size(172, 97);
            this.btnRegistroTipoDeUsuario.TabIndex = 1;
            this.btnRegistroTipoDeUsuario.Text = "Registrar tipo de usuario";
            this.btnRegistroTipoDeUsuario.UseVisualStyleBackColor = true;
            this.btnRegistroTipoDeUsuario.Click += new System.EventHandler(this.btnRegistroTipoDeUsuario_Click);
            // 
            // MenuEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 348);
            this.Controls.Add(this.btnRegistroTipoDeUsuario);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Name = "MenuEncargado";
            this.Text = "MenuEncargado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnRegistroTipoDeUsuario;
    }
}