namespace GestorDeTiempo
{
    partial class VistaGeneralEncargado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtNombreDep = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(480, 69);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 1;
            this.btnDetalle.Text = "Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(13, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Enabled = false;
            this.txtNombrePro.Location = new System.Drawing.Point(13, 40);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePro.TabIndex = 3;
            // 
            // txtNombreDep
            // 
            this.txtNombreDep.Enabled = false;
            this.txtNombreDep.Location = new System.Drawing.Point(13, 71);
            this.txtNombreDep.Name = "txtNombreDep";
            this.txtNombreDep.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDep.TabIndex = 4;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Enabled = false;
            this.txtNombreProd.Location = new System.Drawing.Point(13, 98);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProd.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(13, 125);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Location = new System.Drawing.Point(132, 12);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 7;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Enabled = false;
            this.txtEndTime.Location = new System.Drawing.Point(132, 39);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndTime.TabIndex = 8;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(480, 99);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 9;
            this.btnReporte.Text = "GenerarReporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(132, 71);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 10;
            // 
            // VistaGeneralEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 499);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtNombreDep);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VistaGeneralEncargado";
            this.Text = "VistaGeneralEncargado";
            this.Load += new System.EventHandler(this.VistaGeneralEncargado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.TextBox txtNombreDep;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtUser;
    }
}