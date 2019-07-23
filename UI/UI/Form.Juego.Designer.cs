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
            this.timerMonedas = new System.Windows.Forms.Timer(this.components);
            this.imageListNegroRight = new System.Windows.Forms.ImageList(this.components);
            this.pnEscenario = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMoneda5 = new System.Windows.Forms.Label();
            this.lblMoneda4 = new System.Windows.Forms.Label();
            this.lblMoneda3 = new System.Windows.Forms.Label();
            this.lblMoneda2 = new System.Windows.Forms.Label();
            this.lblMoneda1 = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblNegro = new System.Windows.Forms.Label();
            this.timerPanel = new System.Windows.Forms.Timer(this.components);
            this.timerTiempo = new System.Windows.Forms.Timer(this.components);
            this.timerpn = new System.Windows.Forms.Timer(this.components);
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
            // 
            // timerMonedas
            // 
            this.timerMonedas.Tick += new System.EventHandler(this.TimerMoneda1_Tick);
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
            this.pnEscenario.Controls.Add(this.lblGameOver);
            this.pnEscenario.Controls.Add(this.lblTiempo);
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
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGameOver.Cursor = System.Windows.Forms.Cursors.No;
            this.lblGameOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGameOver.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(258, 80);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(274, 154);
            this.lblGameOver.TabIndex = 10;
            this.lblGameOver.Text = "GameOver";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(210, 80);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(339, 50);
            this.lblTiempo.TabIndex = 9;
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblScore.Location = new System.Drawing.Point(3, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(141, 92);
            this.lblScore.TabIndex = 7;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoneda5
            // 
            this.lblMoneda5.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda5.ImageIndex = 0;
            this.lblMoneda5.ImageList = this.imageListMoneda;
            this.lblMoneda5.Location = new System.Drawing.Point(505, 393);
            this.lblMoneda5.Name = "lblMoneda5";
            this.lblMoneda5.Size = new System.Drawing.Size(48, 41);
            this.lblMoneda5.TabIndex = 6;
            this.lblMoneda5.Visible = false;
            // 
            // lblMoneda4
            // 
            this.lblMoneda4.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda4.ImageIndex = 0;
            this.lblMoneda4.ImageList = this.imageListMoneda;
            this.lblMoneda4.Location = new System.Drawing.Point(426, 312);
            this.lblMoneda4.Name = "lblMoneda4";
            this.lblMoneda4.Size = new System.Drawing.Size(44, 47);
            this.lblMoneda4.TabIndex = 5;
            this.lblMoneda4.Visible = false;
            // 
            // lblMoneda3
            // 
            this.lblMoneda3.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda3.ImageIndex = 0;
            this.lblMoneda3.ImageList = this.imageListMoneda;
            this.lblMoneda3.Location = new System.Drawing.Point(348, 393);
            this.lblMoneda3.Name = "lblMoneda3";
            this.lblMoneda3.Size = new System.Drawing.Size(43, 46);
            this.lblMoneda3.TabIndex = 4;
            this.lblMoneda3.Visible = false;
            // 
            // lblMoneda2
            // 
            this.lblMoneda2.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda2.ImageIndex = 0;
            this.lblMoneda2.ImageList = this.imageListMoneda;
            this.lblMoneda2.Location = new System.Drawing.Point(241, 355);
            this.lblMoneda2.Name = "lblMoneda2";
            this.lblMoneda2.Size = new System.Drawing.Size(39, 51);
            this.lblMoneda2.TabIndex = 3;
            this.lblMoneda2.Visible = false;
            // 
            // lblMoneda1
            // 
            this.lblMoneda1.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneda1.ImageIndex = 0;
            this.lblMoneda1.ImageList = this.imageListMoneda;
            this.lblMoneda1.Location = new System.Drawing.Point(101, 406);
            this.lblMoneda1.Name = "lblMoneda1";
            this.lblMoneda1.Size = new System.Drawing.Size(43, 43);
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
            this.lblInformacion.Location = new System.Drawing.Point(124, 0);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(510, 92);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "PRESS BAR TO PLAY";
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNegro
            // 
            this.lblNegro.BackColor = System.Drawing.Color.Transparent;
            this.lblNegro.ImageIndex = 0;
            this.lblNegro.ImageList = this.imageListNegroLeft;
            this.lblNegro.Location = new System.Drawing.Point(616, 346);
            this.lblNegro.Name = "lblNegro";
            this.lblNegro.Size = new System.Drawing.Size(101, 147);
            this.lblNegro.TabIndex = 1;
            // 
            // timerPanel
            // 
            this.timerPanel.Enabled = true;
            this.timerPanel.Interval = 500;
            // 
            // timerTiempo
            // 
            this.timerTiempo.Interval = 1000;
            this.timerTiempo.Tick += new System.EventHandler(this.TimerTiempo_Tick);
            // 
            // timerpn
            // 
            this.timerpn.Enabled = true;
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
        private System.Windows.Forms.Timer timerMonedas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ImageList imageListNegroRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerPanel;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer timerTiempo;
        private System.Windows.Forms.Label lblGameOver;
        public System.Windows.Forms.Timer timerpn;
    }
}