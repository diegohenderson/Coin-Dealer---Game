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
            this.pnEscenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEscenario
            // 
            this.pnEscenario.Controls.Add(this.lblNegro);
            this.pnEscenario.Location = new System.Drawing.Point(21, 12);
            this.pnEscenario.Name = "pnEscenario";
            this.pnEscenario.Size = new System.Drawing.Size(751, 426);
            this.pnEscenario.TabIndex = 0;
            // 
            // lblNegro
            // 
            this.lblNegro.ImageIndex = 0;
            this.lblNegro.ImageList = this.imageList1;
            this.lblNegro.Location = new System.Drawing.Point(558, 245);
            this.lblNegro.Name = "lblNegro";
            this.lblNegro.Size = new System.Drawing.Size(190, 172);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}