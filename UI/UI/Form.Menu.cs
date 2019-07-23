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
            
            Form formjuego = new Form2();
            formjuego.ShowDialog();
            this.Dispose();
            timerMoneda.Stop();
            timerNegroIdle.Stop();
            
        }



        private void BtCreditos_Click(object sender, EventArgs e)
        {
            Form formCreditos = new Form4();
            formCreditos.ShowDialog();
        }

        private void Btn_Opcion_Click_1(object sender, EventArgs e)
        {
            Form formOpcion = new Form3();
            formOpcion.ShowDialog();
        }

        private void TimerNegroIdle_Tick(object sender, EventArgs e)
        {
            if (lblAnimacionNegroIdle.ImageIndex < 7)
            {
                lblAnimacionNegroIdle.ImageIndex = lblAnimacionNegroIdle.ImageIndex + 1;
            }
            else
            {
                lblAnimacionNegroIdle.ImageIndex = 1;
            }
        }

        private void TimerMoneda_Tick(object sender, EventArgs e)
        {
            if (lblMoneda.ImageIndex < 5)
            {
                lblMoneda.ImageIndex = lblMoneda.ImageIndex + 1;
            }
            else
            {
                lblMoneda.ImageIndex = 1;
            }
        }
    }
}
