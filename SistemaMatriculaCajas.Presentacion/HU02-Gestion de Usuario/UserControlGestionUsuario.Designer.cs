namespace SistemaMatriculaCajas.Presentacion.HU02_Gestion_de_Usuario
{
    partial class UserControlGestionUsuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNuwvoUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuwvoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(404, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "GESTION DE USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaMatriculaCajas.Presentacion.Properties.Resources.list__2_;
            this.pictureBox2.Location = new System.Drawing.Point(546, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnNuwvoUsuario
            // 
            this.btnNuwvoUsuario.Image = global::SistemaMatriculaCajas.Presentacion.Properties.Resources.user__4_;
            this.btnNuwvoUsuario.Location = new System.Drawing.Point(211, 229);
            this.btnNuwvoUsuario.Name = "btnNuwvoUsuario";
            this.btnNuwvoUsuario.Size = new System.Drawing.Size(256, 256);
            this.btnNuwvoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnNuwvoUsuario.TabIndex = 5;
            this.btnNuwvoUsuario.TabStop = false;
            this.btnNuwvoUsuario.Click += new System.EventHandler(this.btnNuwvoUsuario_Click_1);
            // 
            // UserControlGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnNuwvoUsuario);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGestionUsuario";
            this.Size = new System.Drawing.Size(984, 728);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuwvoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnNuwvoUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
