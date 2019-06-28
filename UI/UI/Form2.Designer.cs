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
            this.imageListNegro = new System.Windows.Forms.ImageList(this.components);
            this.lblMoneda = new System.Windows.Forms.Label();
            this.imageListMoneda = new System.Windows.Forms.ImageList(this.components);
            this.pnEscenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEscenario
            // 
            this.pnEscenario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnEscenario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEscenario.BackgroundImage")));
            this.pnEscenario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnEscenario.Controls.Add(this.lblMoneda);
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
            this.lblNegro.ImageList = this.imageListNegro;
            this.lblNegro.Location = new System.Drawing.Point(605, 239);
            this.lblNegro.Name = "lblNegro";
            this.lblNegro.Size = new System.Drawing.Size(112, 161);
            this.lblNegro.TabIndex = 0;
            this.lblNegro.Click += new System.EventHandler(this.LblNegro_Click);
            // 
            // imageListNegro
            // 
            this.imageListNegro.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNegro.ImageStream")));
            this.imageListNegro.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNegro.Images.SetKeyName(0, "0000.png");
            this.imageListNegro.Images.SetKeyName(1, "0001.png");
            this.imageListNegro.Images.SetKeyName(2, "0002.png");
            this.imageListNegro.Images.SetKeyName(3, "0003.png");
            this.imageListNegro.Images.SetKeyName(4, "0004.png");
            this.imageListNegro.Images.SetKeyName(5, "0005.png");
            this.imageListNegro.Images.SetKeyName(6, "0006.png");
            this.imageListNegro.Images.SetKeyName(7, "0007.png");
            // 
            // lblMoneda
            // 
            this.lblMoneda.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda.ImageIndex = 0;
            this.lblMoneda.ImageList = this.imageListMoneda;
            this.lblMoneda.Location = new System.Drawing.Point(150, 223);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(95, 56);
            this.lblMoneda.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEscenario;
        private System.Windows.Forms.Label lblNegro;
        private System.Windows.Forms.ImageList imageListNegro;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ImageList imageListMoneda;
    }
}