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
            this.btn_Click = new System.Windows.Forms.Button();
            this.bar_animacion = new System.Windows.Forms.ProgressBar();
            this.lbl_txt_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Click
            // 
            this.btn_Click.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Click.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Click.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Click.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Click.Location = new System.Drawing.Point(204, 144);
            this.btn_Click.Name = "btn_Click";
            this.btn_Click.Size = new System.Drawing.Size(509, 110);
            this.btn_Click.TabIndex = 0;
            this.btn_Click.Text = "Haga Click para Continuar";
            this.btn_Click.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Click.UseVisualStyleBackColor = false;
            this.btn_Click.Click += new System.EventHandler(this.Btn_saludo_Click);
            // 
            // bar_animacion
            // 
            this.bar_animacion.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bar_animacion.Location = new System.Drawing.Point(204, 260);
            this.bar_animacion.Name = "bar_animacion";
            this.bar_animacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bar_animacion.Size = new System.Drawing.Size(509, 26);
            this.bar_animacion.Step = 5;
            this.bar_animacion.TabIndex = 1;
            // 
            // lbl_txt_1
            // 
            this.lbl_txt_1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_1.Location = new System.Drawing.Point(320, 46);
            this.lbl_txt_1.Name = "lbl_txt_1";
            this.lbl_txt_1.Size = new System.Drawing.Size(246, 57);
            this.lbl_txt_1.TabIndex = 2;
            this.lbl_txt_1.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(872, 455);
            this.Controls.Add(this.lbl_txt_1);
            this.Controls.Add(this.bar_animacion);
            this.Controls.Add(this.btn_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Click;
        private System.Windows.Forms.ProgressBar bar_animacion;
        private System.Windows.Forms.Label lbl_txt_1;
    }
}

