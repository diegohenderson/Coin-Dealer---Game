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
            this.imageListMoneda = new System.Windows.Forms.ImageList(this.components);
            this.imageListNegroLeft = new System.Windows.Forms.ImageList(this.components);
            this.timerMoneda1 = new System.Windows.Forms.Timer(this.components);
            this.timerMoneda2 = new System.Windows.Forms.Timer(this.components);
            this.timerMoneda3 = new System.Windows.Forms.Timer(this.components);
            this.timerMoneda4 = new System.Windows.Forms.Timer(this.components);
            this.timerMoneda5 = new System.Windows.Forms.Timer(this.components);
            this.imageListNegroRight = new System.Windows.Forms.ImageList(this.components);
            this.pnEscenario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMoneda5 = new System.Windows.Forms.Label();
            this.lblMoneda4 = new System.Windows.Forms.Label();
            this.lblMoneda3 = new System.Windows.Forms.Label();
            this.lblMoneda2 = new System.Windows.Forms.Label();
            this.lblMoneda1 = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblNegro = new System.Windows.Forms.Label();
            this.pnEscenario.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMoneda
            // 
            this.imageListMoneda.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMoneda.ImageStream")));
            this.imageListMoneda.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMoneda.Images.SetKeyName(0, "star coin 1.png");
            this.imageListMoneda.Images.SetKeyName(1, "star coin rotate 2.png");
            this.imageListMoneda.Images.SetKeyName(2, "star coin rotate 3.png");
            this.imageListMoneda.Images.SetKeyName(3, "star coin rotate 4.png");
            this.imageListMoneda.Images.SetKeyName(4, "star coin rotate 5.png");
            this.imageListMoneda.Images.SetKeyName(5, "star coin rotate 6.png");
            // 
            // imageListNegroLeft
            // 
            this.imageListNegroLeft.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNegroLeft.ImageStream")));
            this.imageListNegroLeft.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNegroLeft.Images.SetKeyName(0, "0000.png");
            this.imageListNegroLeft.Images.SetKeyName(1, "0001.png");
            this.imageListNegroLeft.Images.SetKeyName(2, "0002.png");
            this.imageListNegroLeft.Images.SetKeyName(3, "0003.png");
            this.imageListNegroLeft.Images.SetKeyName(4, "0004.png");
            this.imageListNegroLeft.Images.SetKeyName(5, "0005.png");
            this.imageListNegroLeft.Images.SetKeyName(6, "0006.png");
            this.imageListNegroLeft.Images.SetKeyName(7, "0007.png");
            // 
            // timerMoneda1
            // 
            this.timerMoneda1.Interval = 10;
            this.timerMoneda1.Tick += new System.EventHandler(this.TimerMoneda1_Tick);
            // 
            // timerMoneda2
            // 
            this.timerMoneda2.Interval = 25;
            this.timerMoneda2.Tick += new System.EventHandler(this.TimerMoneda2_Tick);
            // 
            // timerMoneda3
            // 
            this.timerMoneda3.Interval = 30;
            this.timerMoneda3.Tick += new System.EventHandler(this.TimerMoneda3_Tick);
            // 
            // timerMoneda4
            // 
            this.timerMoneda4.Interval = 50;
            this.timerMoneda4.Tick += new System.EventHandler(this.TimerMoneda4_Tick);
            // 
            // timerMoneda5
            // 
            this.timerMoneda5.Interval = 150;
            this.timerMoneda5.Tick += new System.EventHandler(this.TimerMoneda5_Tick);
            // 
            // imageListNegroRight
            // 
            this.imageListNegroRight.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNegroRight.ImageStream")));
            this.imageListNegroRight.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNegroRight.Images.SetKeyName(0, "0000.png");
            this.imageListNegroRight.Images.SetKeyName(1, "0001.png");
            this.imageListNegroRight.Images.SetKeyName(2, "0002.png");
            this.imageListNegroRight.Images.SetKeyName(3, "0003.png");
            this.imageListNegroRight.Images.SetKeyName(4, "0004.png");
            this.imageListNegroRight.Images.SetKeyName(5, "0005.png");
            // 
            // pnEscenario
            // 
            this.pnEscenario.BackColor = System.Drawing.Color.DimGray;
            this.pnEscenario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEscenario.BackgroundImage")));
            this.pnEscenario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnEscenario.Controls.Add(this.label1);
            this.pnEscenario.Controls.Add(this.lblScore);
            this.pnEscenario.Controls.Add(this.lblMoneda5);
            this.pnEscenario.Controls.Add(this.lblMoneda4);
            this.pnEscenario.Controls.Add(this.lblMoneda3);
            this.pnEscenario.Controls.Add(this.lblMoneda2);
            this.pnEscenario.Controls.Add(this.lblMoneda1);
            this.pnEscenario.Controls.Add(this.lblInformacion);
            this.pnEscenario.Controls.Add(this.lblNegro);
            this.pnEscenario.Location = new System.Drawing.Point(3, 2);
            this.pnEscenario.Name = "pnEscenario";
            this.pnEscenario.Size = new System.Drawing.Size(779, 512);
            this.pnEscenario.TabIndex = 0;
            this.pnEscenario.Tag = "Panel";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 20);
            this.label1.TabIndex = 8;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScore.Font = new System.Drawing.Font("Ink Free", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(610, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(165, 73);
            this.lblScore.TabIndex = 7;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoneda5
            // 
            this.lblMoneda5.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda5.ImageIndex = 0;
            this.lblMoneda5.ImageList = this.imageListMoneda;
            this.lblMoneda5.Location = new System.Drawing.Point(607, 393);
            this.lblMoneda5.Name = "lblMoneda5";
            this.lblMoneda5.Size = new System.Drawing.Size(63, 61);
            this.lblMoneda5.TabIndex = 6;
            this.lblMoneda5.Visible = false;
            // 
            // lblMoneda4
            // 
            this.lblMoneda4.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda4.ImageIndex = 0;
            this.lblMoneda4.ImageList = this.imageListMoneda;
            this.lblMoneda4.Location = new System.Drawing.Point(500, 341);
            this.lblMoneda4.Name = "lblMoneda4";
            this.lblMoneda4.Size = new System.Drawing.Size(57, 53);
            this.lblMoneda4.TabIndex = 5;
            this.lblMoneda4.Visible = false;
            // 
            // lblMoneda3
            // 
            this.lblMoneda3.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda3.ImageIndex = 0;
            this.lblMoneda3.ImageList = this.imageListMoneda;
            this.lblMoneda3.Location = new System.Drawing.Point(353, 300);
            this.lblMoneda3.Name = "lblMoneda3";
            this.lblMoneda3.Size = new System.Drawing.Size(51, 54);
            this.lblMoneda3.TabIndex = 4;
            this.lblMoneda3.Visible = false;
            // 
            // lblMoneda2
            // 
            this.lblMoneda2.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda2.ImageIndex = 0;
            this.lblMoneda2.ImageList = this.imageListMoneda;
            this.lblMoneda2.Location = new System.Drawing.Point(232, 388);
            this.lblMoneda2.Name = "lblMoneda2";
            this.lblMoneda2.Size = new System.Drawing.Size(55, 66);
            this.lblMoneda2.TabIndex = 3;
            this.lblMoneda2.Visible = false;
            // 
            // lblMoneda1
            // 
            this.lblMoneda1.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda1.ImageIndex = 0;
            this.lblMoneda1.ImageList = this.imageListMoneda;
            this.lblMoneda1.Location = new System.Drawing.Point(115, 275);
            this.lblMoneda1.Name = "lblMoneda1";
            this.lblMoneda1.Size = new System.Drawing.Size(61, 56);
            this.lblMoneda1.TabIndex = 2;
            this.lblMoneda1.Visible = false;
            // 
            // lblInformacion
            // 
            this.lblInformacion.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInformacion.Font = new System.Drawing.Font("Ink Free", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Black;
            this.lblInformacion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblInformacion.Location = new System.Drawing.Point(73, 13);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(522, 92);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "PRESS BAR TO PLAY";
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNegro
            // 
            this.lblNegro.BackColor = System.Drawing.Color.Transparent;
            this.lblNegro.ImageIndex = 0;
            this.lblNegro.ImageList = this.imageListNegroLeft;
            this.lblNegro.Location = new System.Drawing.Point(664, 341);
            this.lblNegro.Name = "lblNegro";
            this.lblNegro.Size = new System.Drawing.Size(112, 161);
            this.lblNegro.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(786, 520);
            this.Controls.Add(this.pnEscenario);
            this.Name = "Form2";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.pnEscenario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEscenario;
        private System.Windows.Forms.Label lblNegro;
        private System.Windows.Forms.ImageList imageListNegroLeft;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.ImageList imageListMoneda;
        private System.Windows.Forms.Label lblMoneda5;
        private System.Windows.Forms.Label lblMoneda4;
        private System.Windows.Forms.Label lblMoneda3;
        private System.Windows.Forms.Label lblMoneda2;
        private System.Windows.Forms.Label lblMoneda1;
        private System.Windows.Forms.Timer timerMoneda1;
        private System.Windows.Forms.Timer timerMoneda2;
        private System.Windows.Forms.Timer timerMoneda3;
        private System.Windows.Forms.Timer timerMoneda4;
        private System.Windows.Forms.Timer timerMoneda5;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ImageList imageListNegroRight;
        private System.Windows.Forms.Label label1;
    }
}