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
            this.lblNegro = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblInformacion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnEscenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEscenario
            // 
            this.pnEscenario.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnEscenario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnEscenario.Controls.Add(this.lblInformacion);
            this.pnEscenario.Controls.Add(this.lblNegro);
            this.pnEscenario.Location = new System.Drawing.Point(2, 3);
            this.pnEscenario.Name = "pnEscenario";
            this.pnEscenario.Size = new System.Drawing.Size(797, 448);
            this.pnEscenario.TabIndex = 0;
            // 
            // lblNegro
            // 
            this.lblNegro.BackColor = System.Drawing.Color.Transparent;
            this.lblNegro.ImageIndex = 0;
            this.lblNegro.ImageList = this.imageList1;
            this.lblNegro.Location = new System.Drawing.Point(642, 232);
            this.lblNegro.Name = "lblNegro";
            this.lblNegro.Size = new System.Drawing.Size(95, 183);
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
            // lblInformacion
            // 
            this.lblInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacion.Enabled = false;
            this.lblInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Black;
            this.lblInformacion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblInformacion.Location = new System.Drawing.Point(256, 18);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(364, 83);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Click en el personaje para empezar";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnEscenario);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnEscenario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEscenario;
        private System.Windows.Forms.Label lblNegro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Timer timer1;
    }
}