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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDni_Usuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPass_Usuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtonAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtonCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 26);
            this.panel1.TabIndex = 3;
            // 
            // txtDni_Usuario
            // 
            this.txtDni_Usuario.BackColor = System.Drawing.Color.White;
            this.txtDni_Usuario.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtDni_Usuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni_Usuario.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtDni_Usuario.BorderThickness = 3;
            this.txtDni_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDni_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDni_Usuario.isPassword = false;
            this.txtDni_Usuario.Location = new System.Drawing.Point(96, 185);
            this.txtDni_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni_Usuario.Name = "txtDni_Usuario";
            this.txtDni_Usuario.Size = new System.Drawing.Size(301, 42);
            this.txtDni_Usuario.TabIndex = 5;
            this.txtDni_Usuario.Text = "Usuario";
            this.txtDni_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass_Usuario
            // 
            this.txtPass_Usuario.BackColor = System.Drawing.Color.White;
            this.txtPass_Usuario.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtPass_Usuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass_Usuario.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtPass_Usuario.BorderThickness = 3;
            this.txtPass_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass_Usuario.isPassword = false;
            this.txtPass_Usuario.Location = new System.Drawing.Point(96, 267);
            this.txtPass_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass_Usuario.Name = "txtPass_Usuario";
            this.txtPass_Usuario.Size = new System.Drawing.Size(301, 42);
            this.txtPass_Usuario.TabIndex = 6;
            this.txtPass_Usuario.Text = "Contraseña";
            this.txtPass_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(203, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN";
            // 
            // BtonAceptar
            // 
            this.BtonAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(72)))));
            this.BtonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtonAceptar.BorderRadius = 0;
            this.BtonAceptar.ButtonText = "Aceptar";
            this.BtonAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtonAceptar.DisabledColor = System.Drawing.Color.Gray;
            this.BtonAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtonAceptar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtonAceptar.Iconimage")));
            this.BtonAceptar.Iconimage_right = null;
            this.BtonAceptar.Iconimage_right_Selected = null;
            this.BtonAceptar.Iconimage_Selected = null;
            this.BtonAceptar.IconMarginLeft = 0;
            this.BtonAceptar.IconMarginRight = 0;
            this.BtonAceptar.IconRightVisible = true;
            this.BtonAceptar.IconRightZoom = 0D;
            this.BtonAceptar.IconVisible = true;
            this.BtonAceptar.IconZoom = 90D;
            this.BtonAceptar.IsTab = false;
            this.BtonAceptar.Location = new System.Drawing.Point(83, 371);
            this.BtonAceptar.Name = "BtonAceptar";
            this.BtonAceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(190)))), ((int)(((byte)(72)))));
            this.BtonAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtonAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtonAceptar.selected = false;
            this.BtonAceptar.Size = new System.Drawing.Size(142, 44);
            this.BtonAceptar.TabIndex = 40;
            this.BtonAceptar.Text = "Aceptar";
            this.BtonAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonAceptar.Textcolor = System.Drawing.Color.White;
            this.BtonAceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonAceptar.Click += new System.EventHandler(this.BtonAceptar_Click);
            // 
            // BtonCancelar
            // 
            this.BtonCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BtonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtonCancelar.BorderRadius = 0;
            this.BtonCancelar.ButtonText = "Cancelar";
            this.BtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtonCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.BtonCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtonCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtonCancelar.Iconimage")));
            this.BtonCancelar.Iconimage_right = null;
            this.BtonCancelar.Iconimage_right_Selected = null;
            this.BtonCancelar.Iconimage_Selected = null;
            this.BtonCancelar.IconMarginLeft = 0;
            this.BtonCancelar.IconMarginRight = 0;
            this.BtonCancelar.IconRightVisible = true;
            this.BtonCancelar.IconRightZoom = 0D;
            this.BtonCancelar.IconVisible = true;
            this.BtonCancelar.IconZoom = 90D;
            this.BtonCancelar.IsTab = false;
            this.BtonCancelar.Location = new System.Drawing.Point(281, 371);
            this.BtonCancelar.Name = "BtonCancelar";
            this.BtonCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BtonCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BtonCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtonCancelar.selected = false;
            this.BtonCancelar.Size = new System.Drawing.Size(140, 44);
            this.BtonCancelar.TabIndex = 41;
            this.BtonCancelar.Text = "Cancelar";
            this.BtonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonCancelar.Textcolor = System.Drawing.Color.White;
            this.BtonCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonCancelar.Click += new System.EventHandler(this.BtonCancelar_Click);
            // 
            // GUI_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(501, 433);
            this.Controls.Add(this.BtonCancelar);
            this.Controls.Add(this.BtonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass_Usuario);
            this.Controls.Add(this.txtDni_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDni_Usuario;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtonCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton BtonAceptar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPass_Usuario;
    }
}