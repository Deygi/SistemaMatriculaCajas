namespace SistemaMatriculaCajas.Presentacion.HU02_Gestion_de_Usuario
{
    partial class Form_NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NuevoUsuario));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtboxDni = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtboxApMat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxNom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxApPat = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtboxCodigo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton8 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.bunifuImageButton7);
            this.panel1.Controls.Add(this.bunifuImageButton8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 36);
            this.panel1.TabIndex = 0;
            // 
            // TxtboxDni
            // 
            this.TxtboxDni.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtboxDni.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.TxtboxDni.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.TxtboxDni.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(162)))));
            this.TxtboxDni.BorderThickness = 3;
            this.TxtboxDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxDni.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxDni.isPassword = false;
            this.TxtboxDni.Location = new System.Drawing.Point(34, 505);
            this.TxtboxDni.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxDni.Name = "TxtboxDni";
            this.TxtboxDni.Size = new System.Drawing.Size(327, 44);
            this.TxtboxDni.TabIndex = 6;
            this.TxtboxDni.Text = "DNI";
            this.TxtboxDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtboxApMat
            // 
            this.txtboxApMat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtboxApMat.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.txtboxApMat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtboxApMat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.txtboxApMat.BorderThickness = 3;
            this.txtboxApMat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxApMat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtboxApMat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxApMat.isPassword = false;
            this.txtboxApMat.Location = new System.Drawing.Point(440, 412);
            this.txtboxApMat.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxApMat.Name = "txtboxApMat";
            this.txtboxApMat.Size = new System.Drawing.Size(327, 44);
            this.txtboxApMat.TabIndex = 4;
            this.txtboxApMat.Text = "Apellido Materno";
            this.txtboxApMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxPass
            // 
            this.TxtboxPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtboxPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.TxtboxPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.TxtboxPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(162)))));
            this.TxtboxPass.BorderThickness = 3;
            this.TxtboxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxPass.isPassword = false;
            this.TxtboxPass.Location = new System.Drawing.Point(665, 557);
            this.TxtboxPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxPass.Name = "TxtboxPass";
            this.TxtboxPass.Size = new System.Drawing.Size(327, 44);
            this.TxtboxPass.TabIndex = 2;
            this.TxtboxPass.Text = "Password";
            this.TxtboxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxNom
            // 
            this.TxtboxNom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtboxNom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.TxtboxNom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.TxtboxNom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.TxtboxNom.BorderThickness = 3;
            this.TxtboxNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxNom.isPassword = false;
            this.TxtboxNom.Location = new System.Drawing.Point(847, 412);
            this.TxtboxNom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxNom.Name = "TxtboxNom";
            this.TxtboxNom.Size = new System.Drawing.Size(327, 44);
            this.TxtboxNom.TabIndex = 5;
            this.TxtboxNom.Text = "Nombres";
            this.TxtboxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxApPat
            // 
            this.TxtboxApPat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtboxApPat.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.TxtboxApPat.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.TxtboxApPat.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.TxtboxApPat.BorderThickness = 3;
            this.TxtboxApPat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxApPat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxApPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtboxApPat.isPassword = false;
            this.TxtboxApPat.Location = new System.Drawing.Point(34, 412);
            this.TxtboxApPat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxApPat.Name = "TxtboxApPat";
            this.TxtboxApPat.Size = new System.Drawing.Size(327, 44);
            this.TxtboxApPat.TabIndex = 3;
            this.TxtboxApPat.Text = "Apellido Paterno";
            this.TxtboxApPat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtboxCodigo
            // 
            this.TxtboxCodigo.BorderColorFocused = System.Drawing.Color.Blue;
            this.TxtboxCodigo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.TxtboxCodigo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TxtboxCodigo.BorderThickness = 3;
            this.TxtboxCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtboxCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtboxCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.TxtboxCodigo.isPassword = false;
            this.TxtboxCodigo.Location = new System.Drawing.Point(205, 557);
            this.TxtboxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtboxCodigo.Name = "TxtboxCodigo";
            this.TxtboxCodigo.Size = new System.Drawing.Size(370, 44);
            this.TxtboxCodigo.TabIndex = 1;
            this.TxtboxCodigo.Text = "Codigo";
            this.TxtboxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 88);
            this.panel2.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(495, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nuevo Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMatriculaCajas.Presentacion.Properties.Resources.new_user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(524, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(86)))), ((int)(((byte)(96)))));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.BorderRadius = 0;
            this.BtnCancelar.ButtonText = "Cancelar";
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Iconimage = global::SistemaMatriculaCajas.Presentacion.Properties.Resources.cross_remove_sign;
            this.BtnCancelar.Iconimage_right = null;
            this.BtnCancelar.Iconimage_right_Selected = null;
            this.BtnCancelar.Iconimage_Selected = null;
            this.BtnCancelar.IconMarginLeft = 0;
            this.BtnCancelar.IconMarginRight = 0;
            this.BtnCancelar.IconRightVisible = true;
            this.BtnCancelar.IconRightZoom = 0D;
            this.BtnCancelar.IconVisible = true;
            this.BtnCancelar.IconZoom = 45D;
            this.BtnCancelar.IsTab = false;
            this.BtnCancelar.Location = new System.Drawing.Point(1025, 691);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(86)))), ((int)(((byte)(96)))));
            this.BtnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.BtnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCancelar.selected = false;
            this.BtnCancelar.Size = new System.Drawing.Size(161, 48);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancelar.Textcolor = System.Drawing.Color.White;
            this.BtnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(104)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "Guardar";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = global::SistemaMatriculaCajas.Presentacion.Properties.Resources.floppy_disk_digital_data_storage_or_save_interface_symbol;
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 45D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(831, 691);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(104)))));
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(161, 48);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(250)))));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.BorderRadius = 0;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNuevo.Iconimage = global::SistemaMatriculaCajas.Presentacion.Properties.Resources.add_user_button__2_;
            this.btnNuevo.Iconimage_right = null;
            this.btnNuevo.Iconimage_right_Selected = null;
            this.btnNuevo.Iconimage_Selected = null;
            this.btnNuevo.IconMarginLeft = 10;
            this.btnNuevo.IconMarginRight = 0;
            this.btnNuevo.IconRightVisible = true;
            this.btnNuevo.IconRightZoom = 0D;
            this.btnNuevo.IconVisible = true;
            this.btnNuevo.IconZoom = 50D;
            this.btnNuevo.IsTab = false;
            this.btnNuevo.Location = new System.Drawing.Point(639, 691);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.btnNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(250)))));
            this.btnNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNuevo.selected = false;
            this.btnNuevo.Size = new System.Drawing.Size(161, 48);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Textcolor = System.Drawing.Color.White;
            this.btnNuevo.TextFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(1138, 11);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(20, 15);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 22;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // bunifuImageButton8
            // 
            this.bunifuImageButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.bunifuImageButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton8.Image")));
            this.bunifuImageButton8.ImageActive = null;
            this.bunifuImageButton8.Location = new System.Drawing.Point(1166, 11);
            this.bunifuImageButton8.Name = "bunifuImageButton8";
            this.bunifuImageButton8.Size = new System.Drawing.Size(20, 15);
            this.bunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton8.TabIndex = 21;
            this.bunifuImageButton8.TabStop = false;
            this.bunifuImageButton8.Zoom = 10;
            this.bunifuImageButton8.Click += new System.EventHandler(this.bunifuImageButton8_Click);
            // 
            // Form_NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtboxCodigo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.TxtboxDni);
            this.Controls.Add(this.txtboxApMat);
            this.Controls.Add(this.TxtboxPass);
            this.Controls.Add(this.TxtboxNom);
            this.Controls.Add(this.TxtboxApPat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form_NuevoUsuario";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton8;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNuevo;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxDni;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtboxApMat;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxNom;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxApPat;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtboxCodigo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}