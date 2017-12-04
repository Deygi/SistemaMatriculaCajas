namespace SistemaMatriculaCajas.Presentacion.HU02_Gestion_de_Usuario
{
    partial class Form_GestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton7 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxActual = new System.Windows.Forms.ListBox();
            this.listBoxTodos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuitarAllMod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuitarMod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarAllMod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarMod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuImageButton7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 36);
            this.panel1.TabIndex = 34;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1166, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 23;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(1114, 12);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(20, 15);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 22;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 10;
            this.bunifuImageButton7.Click += new System.EventHandler(this.bunifuImageButton7_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(506, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Gestion Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(560, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // listBoxActual
            // 
            this.listBoxActual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxActual.FormattingEnabled = true;
            this.listBoxActual.HorizontalScrollbar = true;
            this.listBoxActual.ItemHeight = 17;
            this.listBoxActual.Location = new System.Drawing.Point(813, 252);
            this.listBoxActual.Name = "listBoxActual";
            this.listBoxActual.Size = new System.Drawing.Size(297, 344);
            this.listBoxActual.TabIndex = 38;
            // 
            // listBoxTodos
            // 
            this.listBoxTodos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTodos.FormattingEnabled = true;
            this.listBoxTodos.ItemHeight = 17;
            this.listBoxTodos.Location = new System.Drawing.Point(93, 252);
            this.listBoxTodos.Name = "listBoxTodos";
            this.listBoxTodos.Size = new System.Drawing.Size(297, 344);
            this.listBoxTodos.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 172);
            this.panel2.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaMatriculaCajas.Presentacion.Properties.Resources.loop;
            this.pictureBox1.Location = new System.Drawing.Point(490, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuitarAllMod
            // 
            this.btnQuitarAllMod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnQuitarAllMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarAllMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarAllMod.BorderRadius = 0;
            this.btnQuitarAllMod.ButtonText = "<<";
            this.btnQuitarAllMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarAllMod.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuitarAllMod.Enabled = false;
            this.btnQuitarAllMod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuitarAllMod.Iconimage = null;
            this.btnQuitarAllMod.Iconimage_right = null;
            this.btnQuitarAllMod.Iconimage_right_Selected = null;
            this.btnQuitarAllMod.Iconimage_Selected = null;
            this.btnQuitarAllMod.IconMarginLeft = 0;
            this.btnQuitarAllMod.IconMarginRight = 0;
            this.btnQuitarAllMod.IconRightVisible = true;
            this.btnQuitarAllMod.IconRightZoom = 0D;
            this.btnQuitarAllMod.IconVisible = true;
            this.btnQuitarAllMod.IconZoom = 90D;
            this.btnQuitarAllMod.IsTab = false;
            this.btnQuitarAllMod.Location = new System.Drawing.Point(720, 548);
            this.btnQuitarAllMod.Name = "btnQuitarAllMod";
            this.btnQuitarAllMod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarAllMod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnQuitarAllMod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitarAllMod.selected = false;
            this.btnQuitarAllMod.Size = new System.Drawing.Size(87, 47);
            this.btnQuitarAllMod.TabIndex = 40;
            this.btnQuitarAllMod.Text = "<<";
            this.btnQuitarAllMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitarAllMod.Textcolor = System.Drawing.Color.White;
            this.btnQuitarAllMod.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarAllMod.Click += new System.EventHandler(this.btnQuitarAllMod_Click);
            // 
            // btnQuitarMod
            // 
            this.btnQuitarMod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnQuitarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarMod.BorderRadius = 0;
            this.btnQuitarMod.ButtonText = "<";
            this.btnQuitarMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarMod.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuitarMod.Enabled = false;
            this.btnQuitarMod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuitarMod.Iconimage = null;
            this.btnQuitarMod.Iconimage_right = null;
            this.btnQuitarMod.Iconimage_right_Selected = null;
            this.btnQuitarMod.Iconimage_Selected = null;
            this.btnQuitarMod.IconMarginLeft = 0;
            this.btnQuitarMod.IconMarginRight = 0;
            this.btnQuitarMod.IconRightVisible = true;
            this.btnQuitarMod.IconRightZoom = 0D;
            this.btnQuitarMod.IconVisible = true;
            this.btnQuitarMod.IconZoom = 90D;
            this.btnQuitarMod.IsTab = false;
            this.btnQuitarMod.Location = new System.Drawing.Point(720, 495);
            this.btnQuitarMod.Name = "btnQuitarMod";
            this.btnQuitarMod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnQuitarMod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnQuitarMod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitarMod.selected = false;
            this.btnQuitarMod.Size = new System.Drawing.Size(87, 47);
            this.btnQuitarMod.TabIndex = 41;
            this.btnQuitarMod.Text = "<";
            this.btnQuitarMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuitarMod.Textcolor = System.Drawing.Color.White;
            this.btnQuitarMod.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarMod.Click += new System.EventHandler(this.btnQuitarMod_Click);
            // 
            // btnAgregarAllMod
            // 
            this.btnAgregarAllMod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(104)))));
            this.btnAgregarAllMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.btnAgregarAllMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarAllMod.BorderRadius = 0;
            this.btnAgregarAllMod.ButtonText = ">>";
            this.btnAgregarAllMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAllMod.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarAllMod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarAllMod.Iconimage = null;
            this.btnAgregarAllMod.Iconimage_right = null;
            this.btnAgregarAllMod.Iconimage_right_Selected = null;
            this.btnAgregarAllMod.Iconimage_Selected = null;
            this.btnAgregarAllMod.IconMarginLeft = 0;
            this.btnAgregarAllMod.IconMarginRight = 0;
            this.btnAgregarAllMod.IconRightVisible = true;
            this.btnAgregarAllMod.IconRightZoom = 0D;
            this.btnAgregarAllMod.IconVisible = true;
            this.btnAgregarAllMod.IconZoom = 90D;
            this.btnAgregarAllMod.IsTab = false;
            this.btnAgregarAllMod.Location = new System.Drawing.Point(396, 252);
            this.btnAgregarAllMod.Name = "btnAgregarAllMod";
            this.btnAgregarAllMod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.btnAgregarAllMod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(104)))));
            this.btnAgregarAllMod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarAllMod.selected = false;
            this.btnAgregarAllMod.Size = new System.Drawing.Size(87, 47);
            this.btnAgregarAllMod.TabIndex = 42;
            this.btnAgregarAllMod.Text = ">>";
            this.btnAgregarAllMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarAllMod.Textcolor = System.Drawing.Color.White;
            this.btnAgregarAllMod.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarAllMod.Click += new System.EventHandler(this.btnAgregarAllMod_Click);
            // 
            // btnAgregarMod
            // 
            this.btnAgregarMod.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(104)))));
            this.btnAgregarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.btnAgregarMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMod.BorderRadius = 0;
            this.btnAgregarMod.ButtonText = ">";
            this.btnAgregarMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMod.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarMod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarMod.Iconimage = null;
            this.btnAgregarMod.Iconimage_right = null;
            this.btnAgregarMod.Iconimage_right_Selected = null;
            this.btnAgregarMod.Iconimage_Selected = null;
            this.btnAgregarMod.IconMarginLeft = 0;
            this.btnAgregarMod.IconMarginRight = 0;
            this.btnAgregarMod.IconRightVisible = true;
            this.btnAgregarMod.IconRightZoom = 0D;
            this.btnAgregarMod.IconVisible = true;
            this.btnAgregarMod.IconZoom = 90D;
            this.btnAgregarMod.IsTab = false;
            this.btnAgregarMod.Location = new System.Drawing.Point(396, 305);
            this.btnAgregarMod.Name = "btnAgregarMod";
            this.btnAgregarMod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(203)))), ((int)(((byte)(161)))));
            this.btnAgregarMod.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(104)))));
            this.btnAgregarMod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarMod.selected = false;
            this.btnAgregarMod.Size = new System.Drawing.Size(87, 47);
            this.btnAgregarMod.TabIndex = 43;
            this.btnAgregarMod.Text = ">";
            this.btnAgregarMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarMod.Textcolor = System.Drawing.Color.White;
            this.btnAgregarMod.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMod.Click += new System.EventHandler(this.btnAgregarMod_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCancelar.BorderRadius = 0;
            this.BtnCancelar.ButtonText = "Cancelar";
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Iconimage")));
            this.BtnCancelar.Iconimage_right = null;
            this.BtnCancelar.Iconimage_right_Selected = null;
            this.BtnCancelar.Iconimage_Selected = null;
            this.BtnCancelar.IconMarginLeft = 0;
            this.BtnCancelar.IconMarginRight = 0;
            this.BtnCancelar.IconRightVisible = true;
            this.BtnCancelar.IconRightZoom = 0D;
            this.BtnCancelar.IconVisible = true;
            this.BtnCancelar.IconZoom = 90D;
            this.BtnCancelar.IsTab = false;
            this.BtnCancelar.Location = new System.Drawing.Point(964, 681);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(86)))), ((int)(((byte)(96)))));
            this.BtnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.BtnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCancelar.selected = false;
            this.BtnCancelar.Size = new System.Drawing.Size(204, 48);
            this.BtnCancelar.TabIndex = 36;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Textcolor = System.Drawing.Color.White;
            this.BtnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.BorderRadius = 0;
            this.BtnGuardar.ButtonText = "Guardar";
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.BtnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnGuardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Iconimage")));
            this.BtnGuardar.Iconimage_right = null;
            this.BtnGuardar.Iconimage_right_Selected = null;
            this.BtnGuardar.Iconimage_Selected = null;
            this.BtnGuardar.IconMarginLeft = 0;
            this.BtnGuardar.IconMarginRight = 0;
            this.BtnGuardar.IconRightVisible = true;
            this.BtnGuardar.IconRightZoom = 0D;
            this.BtnGuardar.IconVisible = true;
            this.BtnGuardar.IconZoom = 90D;
            this.BtnGuardar.IsTab = false;
            this.BtnGuardar.Location = new System.Drawing.Point(715, 681);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.BtnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnGuardar.selected = false;
            this.BtnGuardar.Size = new System.Drawing.Size(204, 48);
            this.BtnGuardar.TabIndex = 37;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Textcolor = System.Drawing.Color.White;
            this.BtnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Form_GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1198, 768);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitarAllMod);
            this.Controls.Add(this.btnQuitarMod);
            this.Controls.Add(this.btnAgregarAllMod);
            this.Controls.Add(this.btnAgregarMod);
            this.Controls.Add(this.listBoxActual);
            this.Controls.Add(this.listBoxTodos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_GestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_GestionUsuario";
            this.Load += new System.EventHandler(this.Form_GestionUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuitarAllMod;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuitarMod;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarAllMod;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarMod;
        private System.Windows.Forms.ListBox listBoxActual;
        private System.Windows.Forms.ListBox listBoxTodos;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton BtnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}