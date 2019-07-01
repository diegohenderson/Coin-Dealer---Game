namespace UI
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Jugar = new System.Windows.Forms.Button();
            this.lbl_txt_1 = new System.Windows.Forms.Label();
            this.btn_Opcion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btCreditos = new System.Windows.Forms.Button();
            this.lblAnimacionNegroIdle = new System.Windows.Forms.Label();
            this.imageListNegroIdle = new System.Windows.Forms.ImageList(this.components);
            this.timerNegroIdle = new System.Windows.Forms.Timer(this.components);
            this.imageListMoneda = new System.Windows.Forms.ImageList(this.components);
            this.lblMoneda = new System.Windows.Forms.Label();
            this.timerMoneda = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Jugar
            // 
            this.btn_Jugar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Jugar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_Jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Jugar.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jugar.ForeColor = System.Drawing.Color.Black;
            this.btn_Jugar.Location = new System.Drawing.Point(415, 7);
            this.btn_Jugar.Name = "btn_Jugar";
            this.btn_Jugar.Size = new System.Drawing.Size(175, 114);
            this.btn_Jugar.TabIndex = 0;
            this.btn_Jugar.Text = "JUGAR";
            this.btn_Jugar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Jugar.UseVisualStyleBackColor = false;
            this.btn_Jugar.Click += new System.EventHandler(this.Btn_saludo_Click);
            // 
            // lbl_txt_1
            // 
            this.lbl_txt_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_txt_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_txt_1.Font = new System.Drawing.Font("Ink Free", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_1.Location = new System.Drawing.Point(3, 3);
            this.lbl_txt_1.Name = "lbl_txt_1";
            this.lbl_txt_1.Size = new System.Drawing.Size(406, 130);
            this.lbl_txt_1.TabIndex = 2;
            this.lbl_txt_1.Text = "COIN DEALER";
            this.lbl_txt_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Opcion
            // 
            this.btn_Opcion.BackColor = System.Drawing.Color.Transparent;
            this.btn_Opcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Opcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Opcion.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Opcion.ForeColor = System.Drawing.Color.Black;
            this.btn_Opcion.Location = new System.Drawing.Point(595, 7);
            this.btn_Opcion.Name = "btn_Opcion";
            this.btn_Opcion.Size = new System.Drawing.Size(128, 110);
            this.btn_Opcion.TabIndex = 3;
            this.btn_Opcion.Text = "Opciones";
            this.btn_Opcion.UseVisualStyleBackColor = false;
            this.btn_Opcion.Click += new System.EventHandler(this.Btn_Opcion_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 197);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // btCreditos
            // 
            this.btCreditos.BackColor = System.Drawing.Color.Transparent;
            this.btCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreditos.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreditos.Location = new System.Drawing.Point(729, 7);
            this.btCreditos.Name = "btCreditos";
            this.btCreditos.Size = new System.Drawing.Size(143, 112);
            this.btCreditos.TabIndex = 8;
            this.btCreditos.Text = "Creditos";
            this.btCreditos.UseVisualStyleBackColor = false;
            this.btCreditos.Click += new System.EventHandler(this.BtCreditos_Click);
            // 
            // lblAnimacionNegroIdle
            // 
            this.lblAnimacionNegroIdle.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimacionNegroIdle.ImageIndex = 0;
            this.lblAnimacionNegroIdle.ImageList = this.imageListNegroIdle;
            this.lblAnimacionNegroIdle.Location = new System.Drawing.Point(504, 218);
            this.lblAnimacionNegroIdle.Name = "lblAnimacionNegroIdle";
            this.lblAnimacionNegroIdle.Size = new System.Drawing.Size(178, 228);
            this.lblAnimacionNegroIdle.TabIndex = 9;
            // 
            // imageListNegroIdle
            // 
            this.imageListNegroIdle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNegroIdle.ImageStream")));
            this.imageListNegroIdle.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNegroIdle.Images.SetKeyName(0, "0000.png");
            this.imageListNegroIdle.Images.SetKeyName(1, "0001.png");
            this.imageListNegroIdle.Images.SetKeyName(2, "0002.png");
            this.imageListNegroIdle.Images.SetKeyName(3, "0003.png");
            this.imageListNegroIdle.Images.SetKeyName(4, "0004.png");
            this.imageListNegroIdle.Images.SetKeyName(5, "0005.png");
            this.imageListNegroIdle.Images.SetKeyName(6, "0006.png");
            this.imageListNegroIdle.Images.SetKeyName(7, "0007.png");
            // 
            // timerNegroIdle
            // 
            this.timerNegroIdle.Enabled = true;
            this.timerNegroIdle.Tick += new System.EventHandler(this.TimerNegroIdle_Tick);
            // 
            // imageListMoneda
            // 
            this.imageListMoneda.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMoneda.ImageStream")));
            this.imageListMoneda.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMoneda.Images.SetKeyName(0, "star coin rotate 1.png");
            this.imageListMoneda.Images.SetKeyName(1, "star coin rotate 2.png");
            this.imageListMoneda.Images.SetKeyName(2, "star coin rotate 3.png");
            this.imageListMoneda.Images.SetKeyName(3, "star coin rotate 4.png");
            this.imageListMoneda.Images.SetKeyName(4, "star coin rotate 5.png");
            this.imageListMoneda.Images.SetKeyName(5, "star coin rotate 6.png");
            // 
            // lblMoneda
            // 
            this.lblMoneda.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda.ImageIndex = 0;
            this.lblMoneda.ImageList = this.imageListMoneda;
            this.lblMoneda.Location = new System.Drawing.Point(342, 229);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(86, 69);
            this.lblMoneda.TabIndex = 10;
            // 
            // timerMoneda
            // 
            this.timerMoneda.Enabled = true;
            this.timerMoneda.Interval = 250;
            this.timerMoneda.Tick += new System.EventHandler(this.TimerMoneda_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 455);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblAnimacionNegroIdle);
            this.Controls.Add(this.btCreditos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Opcion);
            this.Controls.Add(this.lbl_txt_1);
            this.Controls.Add(this.btn_Jugar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Jugar;
        private System.Windows.Forms.Label lbl_txt_1;
        private System.Windows.Forms.Button btn_Opcion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btCreditos;
        private System.Windows.Forms.Label lblAnimacionNegroIdle;
        private System.Windows.Forms.ImageList imageListNegroIdle;
        private System.Windows.Forms.Timer timerNegroIdle;
        private System.Windows.Forms.ImageList imageListMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Timer timerMoneda;
    }
}

