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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Jugar = new System.Windows.Forms.Button();
            this.lbl_txt_1 = new System.Windows.Forms.Label();
            this.btn_Opcion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btCreditos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btn_Opcion.Font = new System.Drawing.Font("Ink Free", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Opcion.ForeColor = System.Drawing.Color.Black;
            this.btn_Opcion.Location = new System.Drawing.Point(595, 7);
            this.btn_Opcion.Name = "btn_Opcion";
            this.btn_Opcion.Size = new System.Drawing.Size(128, 110);
            this.btn_Opcion.TabIndex = 3;
            this.btn_Opcion.Text = "Opciones";
            this.btn_Opcion.UseVisualStyleBackColor = false;
            this.btn_Opcion.Click += new System.EventHandler(this.Btn_Opcion_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UI.Properties.Resources.star_coin_1;
            this.pictureBox2.Location = new System.Drawing.Point(197, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(762, 229);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(872, 455);
            this.Controls.Add(this.btCreditos);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Opcion);
            this.Controls.Add(this.lbl_txt_1);
            this.Controls.Add(this.btn_Jugar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Jugar;
        private System.Windows.Forms.Label lbl_txt_1;
        private System.Windows.Forms.Button btn_Opcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btCreditos;
    }
}

