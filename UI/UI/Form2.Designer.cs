namespace UI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnEscenario = new System.Windows.Forms.Panel();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblNegro = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picturePuntos = new System.Windows.Forms.PictureBox();
            this.pnEscenario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEscenario
            // 
            this.pnEscenario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnEscenario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEscenario.BackgroundImage")));
            this.pnEscenario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnEscenario.Controls.Add(this.picturePuntos);
            this.pnEscenario.Controls.Add(this.lblInformacion);
            this.pnEscenario.Controls.Add(this.lblNegro);
            this.pnEscenario.Location = new System.Drawing.Point(-6, 3);
            this.pnEscenario.Name = "pnEscenario";
            this.pnEscenario.Size = new System.Drawing.Size(711, 411);
            this.pnEscenario.TabIndex = 0;
            this.pnEscenario.Tag = "Panel";
            this.pnEscenario.Paint += new System.Windows.Forms.PaintEventHandler(this.PnEscenario_Paint);
            // 
            // lblInformacion
            // 
            this.lblInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacion.Enabled = false;
            this.lblInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Black;
            this.lblInformacion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblInformacion.Location = new System.Drawing.Point(312, 35);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(364, 83);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Presiona Flecha arriba para jugar";
            // 
            // lblNegro
            // 
            this.lblNegro.BackColor = System.Drawing.Color.Transparent;
            this.lblNegro.ImageIndex = 0;
            this.lblNegro.ImageList = this.imageList1;
            this.lblNegro.Location = new System.Drawing.Point(605, 239);
            this.lblNegro.Name = "lblNegro";
            this.lblNegro.Size = new System.Drawing.Size(112, 161);
            this.lblNegro.TabIndex = 0;
            this.lblNegro.Click += new System.EventHandler(this.LblNegro_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0000.png");
            this.imageList1.Images.SetKeyName(1, "0001.png");
            this.imageList1.Images.SetKeyName(2, "0002.png");
            this.imageList1.Images.SetKeyName(3, "0003.png");
            this.imageList1.Images.SetKeyName(4, "0004.png");
            this.imageList1.Images.SetKeyName(5, "0005.png");
            this.imageList1.Images.SetKeyName(6, "0006.png");
            this.imageList1.Images.SetKeyName(7, "0007.png");
            // 
            // picturePuntos
            // 
            this.picturePuntos.BackColor = System.Drawing.Color.Transparent;
            this.picturePuntos.Location = new System.Drawing.Point(182, 176);
            this.picturePuntos.Name = "picturePuntos";
            this.picturePuntos.Size = new System.Drawing.Size(63, 77);
            this.picturePuntos.TabIndex = 2;
            this.picturePuntos.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(702, 408);
            this.Controls.Add(this.pnEscenario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.pnEscenario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePuntos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEscenario;
        private System.Windows.Forms.Label lblNegro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picturePuntos;
    }
}