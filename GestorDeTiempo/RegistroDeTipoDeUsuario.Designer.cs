namespace GestorDeTiempo
{
    partial class RegistroDeTipoDeUsuario
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
            this.btnResitrarTipo = new System.Windows.Forms.Button();
            this.txtNombreDeTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResitrarTipo
            // 
            this.btnResitrarTipo.Location = new System.Drawing.Point(192, 184);
            this.btnResitrarTipo.Name = "btnResitrarTipo";
            this.btnResitrarTipo.Size = new System.Drawing.Size(100, 23);
            this.btnResitrarTipo.TabIndex = 0;
            this.btnResitrarTipo.Text = "Registrar";
            this.btnResitrarTipo.UseVisualStyleBackColor = true;
            this.btnResitrarTipo.Click += new System.EventHandler(this.btnResitrarTipo_Click);
            // 
            // txtNombreDeTipo
            // 
            this.txtNombreDeTipo.Location = new System.Drawing.Point(192, 142);
            this.txtNombreDeTipo.Name = "txtNombreDeTipo";
            this.txtNombreDeTipo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDeTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de tipo";
            // 
            // RegistroDeTipoDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreDeTipo);
            this.Controls.Add(this.btnResitrarTipo);
            this.Name = "RegistroDeTipoDeUsuario";
            this.Text = "RegistroDeTipoDeUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResitrarTipo;
        private System.Windows.Forms.TextBox txtNombreDeTipo;
        private System.Windows.Forms.Label label1;
    }
}