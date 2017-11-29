namespace SistemaMatriculaCajas.Presentacion.HU01_Autenticacion
{
    partial class GUI_Login
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
            this.txtDni_Usuario = new System.Windows.Forms.TextBox();
            this.txtPass_Usuario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDni_Usuario
            // 
            this.txtDni_Usuario.Location = new System.Drawing.Point(84, 60);
            this.txtDni_Usuario.Name = "txtDni_Usuario";
            this.txtDni_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txtDni_Usuario.TabIndex = 0;
            // 
            // txtPass_Usuario
            // 
            this.txtPass_Usuario.Location = new System.Drawing.Point(84, 117);
            this.txtPass_Usuario.Name = "txtPass_Usuario";
            this.txtPass_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txtPass_Usuario.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(84, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 142);
            this.textBox1.TabIndex = 3;
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPass_Usuario);
            this.Controls.Add(this.txtDni_Usuario);
            this.Name = "GUI_Login";
            this.Text = "GUI_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni_Usuario;
        private System.Windows.Forms.TextBox txtPass_Usuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox textBox1;
    }
}