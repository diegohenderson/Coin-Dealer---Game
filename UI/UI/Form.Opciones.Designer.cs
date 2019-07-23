namespace UI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblOpcionesSonido = new System.Windows.Forms.Label();
            this.lblOpcionesMusica = new System.Windows.Forms.Label();
            this.btOpcionesSonidoOff = new System.Windows.Forms.Button();
            this.btOpcionesSonidoOn = new System.Windows.Forms.Button();
            this.btOpcionesMusicaOff = new System.Windows.Forms.Button();
            this.btOpcionesMusicaOn = new System.Windows.Forms.Button();
            this.lblOpcionesInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpcionesSonido
            // 
            this.lblOpcionesSonido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblOpcionesSonido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpcionesSonido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionesSonido.Location = new System.Drawing.Point(92, 122);
            this.lblOpcionesSonido.Name = "lblOpcionesSonido";
            this.lblOpcionesSonido.Size = new System.Drawing.Size(117, 40);
            this.lblOpcionesSonido.TabIndex = 0;
            this.lblOpcionesSonido.Text = "Sonido";
            this.lblOpcionesSonido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpcionesMusica
            // 
            this.lblOpcionesMusica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblOpcionesMusica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpcionesMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionesMusica.Location = new System.Drawing.Point(92, 183);
            this.lblOpcionesMusica.Name = "lblOpcionesMusica";
            this.lblOpcionesMusica.Size = new System.Drawing.Size(117, 44);
            this.lblOpcionesMusica.TabIndex = 1;
            this.lblOpcionesMusica.Text = "Musica";
            this.lblOpcionesMusica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOpcionesSonidoOff
            // 
            this.btOpcionesSonidoOff.Location = new System.Drawing.Point(244, 131);
            this.btOpcionesSonidoOff.Name = "btOpcionesSonidoOff";
            this.btOpcionesSonidoOff.Size = new System.Drawing.Size(78, 28);
            this.btOpcionesSonidoOff.TabIndex = 2;
            this.btOpcionesSonidoOff.Text = "Off";
            this.btOpcionesSonidoOff.UseVisualStyleBackColor = true;
            // 
            // btOpcionesSonidoOn
            // 
            this.btOpcionesSonidoOn.Location = new System.Drawing.Point(347, 131);
            this.btOpcionesSonidoOn.Name = "btOpcionesSonidoOn";
            this.btOpcionesSonidoOn.Size = new System.Drawing.Size(78, 31);
            this.btOpcionesSonidoOn.TabIndex = 3;
            this.btOpcionesSonidoOn.Text = "on";
            this.btOpcionesSonidoOn.UseVisualStyleBackColor = true;
            // 
            // btOpcionesMusicaOff
            // 
            this.btOpcionesMusicaOff.Location = new System.Drawing.Point(244, 194);
            this.btOpcionesMusicaOff.Name = "btOpcionesMusicaOff";
            this.btOpcionesMusicaOff.Size = new System.Drawing.Size(81, 33);
            this.btOpcionesMusicaOff.TabIndex = 4;
            this.btOpcionesMusicaOff.Text = "off";
            this.btOpcionesMusicaOff.UseVisualStyleBackColor = true;
            // 
            // btOpcionesMusicaOn
            // 
            this.btOpcionesMusicaOn.Location = new System.Drawing.Point(347, 192);
            this.btOpcionesMusicaOn.Name = "btOpcionesMusicaOn";
            this.btOpcionesMusicaOn.Size = new System.Drawing.Size(78, 33);
            this.btOpcionesMusicaOn.TabIndex = 5;
            this.btOpcionesMusicaOn.Text = "on";
            this.btOpcionesMusicaOn.UseVisualStyleBackColor = true;
            // 
            // lblOpcionesInfo
            // 
            this.lblOpcionesInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblOpcionesInfo.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcionesInfo.Location = new System.Drawing.Point(129, 9);
            this.lblOpcionesInfo.Name = "lblOpcionesInfo";
            this.lblOpcionesInfo.Size = new System.Drawing.Size(286, 75);
            this.lblOpcionesInfo.TabIndex = 7;
            this.lblOpcionesInfo.Text = "En Construccion ";
            this.lblOpcionesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(437, 332);
            this.Controls.Add(this.lblOpcionesInfo);
            this.Controls.Add(this.btOpcionesMusicaOn);
            this.Controls.Add(this.btOpcionesMusicaOff);
            this.Controls.Add(this.btOpcionesSonidoOn);
            this.Controls.Add(this.btOpcionesSonidoOff);
            this.Controls.Add(this.lblOpcionesMusica);
            this.Controls.Add(this.lblOpcionesSonido);
            this.Name = "Form3";
            this.Text = "Opciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOpcionesSonido;
        private System.Windows.Forms.Label lblOpcionesMusica;
        private System.Windows.Forms.Button btOpcionesSonidoOff;
        private System.Windows.Forms.Button btOpcionesSonidoOn;
        private System.Windows.Forms.Button btOpcionesMusicaOff;
        private System.Windows.Forms.Button btOpcionesMusicaOn;
        private System.Windows.Forms.Label lblOpcionesInfo;
    }
}