namespace GestorDeTiempo
{
    partial class RegistrarWorkStation
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
            this.txtWorkStationNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrarWorkStation = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWorkStationNombre
            // 
            this.txtWorkStationNombre.Location = new System.Drawing.Point(49, 41);
            this.txtWorkStationNombre.Name = "txtWorkStationNombre";
            this.txtWorkStationNombre.Size = new System.Drawing.Size(144, 20);
            this.txtWorkStationNombre.TabIndex = 0;
            // 
            // btnRegistrarWorkStation
            // 
            this.btnRegistrarWorkStation.Location = new System.Drawing.Point(79, 87);
            this.btnRegistrarWorkStation.Name = "btnRegistrarWorkStation";
            this.btnRegistrarWorkStation.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarWorkStation.TabIndex = 1;
            this.btnRegistrarWorkStation.Text = "Registrar";
            this.btnRegistrarWorkStation.UseVisualStyleBackColor = true;
            this.btnRegistrarWorkStation.Click += new System.EventHandler(this.btnRegistrarWorkStation_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(160, 87);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RegistrarWorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistrarWorkStation);
            this.Controls.Add(this.txtWorkStationNombre);
            this.Name = "RegistrarWorkStation";
            this.Text = "RegistrarWorkStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWorkStationNombre;
        private System.Windows.Forms.Button btnRegistrarWorkStation;
        private System.Windows.Forms.Button btnRegresar;
    }
}