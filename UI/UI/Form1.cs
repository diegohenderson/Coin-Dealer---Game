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
    }
}
