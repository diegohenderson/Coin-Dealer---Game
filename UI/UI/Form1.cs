using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_saludo_Click(object sender, EventArgs e)
        {
            do
            {
                bar_animacion.Value = bar_animacion.Value+1;
            } while (this.bar_animacion.Value < 100);
            Form frm1 = new Form2();
            frm1.ShowDialog();
        }
    }
}
