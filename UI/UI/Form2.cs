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
    public partial class Form2 : Form
    {
        int flagHorizontal = 0;
        int flagVertical = 0;
        int movimiento = 1;
        private int direccion;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void LblNegro_Click(object sender, EventArgs e)
        {
            lblNegro.ImageIndex = 0;
            int contador = 0;
            while (contador <= 700)
            {
                contador++;
                switch (contador)
                {
                    case 100:
                        lblNegro.ImageIndex = 1;
                        break;
                    case 200:
                        lblNegro.ImageIndex = 2;
                        break;
                    case 300:
                        lblNegro.ImageIndex = 3;
                        break;
                    case 400:
                        lblNegro.ImageIndex= 4;
                        break;
                    case 500:
                        lblNegro.ImageIndex = 5;
                        break;
                    case 600:
                        lblNegro.ImageIndex = 6;
                        break;
                    case 700:
                        flagHorizontal = lblNegro.Left;
                        controlLimites(flagHorizontal,0);
                        lblNegro.ImageIndex = 7;
                        lblNegro.Left = lblNegro.Left - 20;
                        contador = 0;
                        break;
                }
                this.Refresh();

            }

        }

        private void controlLimites(int flagHorizontal, int flagVertical)
        {
            if (flagHorizontal < 1)
            {
                direccion = 1;
            }
            else
            {
                direccion = -1;
            }
        }
    }
}
//    public void controlLimites(int l)
//    {
//        if (lblNegro.Left < panel1.Size.Width && flagH == 1)
//        {
//            label1.Left = label1.Left + paso;


//        }
//        else
//        {
//            flagH = -1;
//            label1.Left = label1.Left - paso;
//            if (label1.Left <= 0)
//            {
//                flagH = 1;
//            }
//            //if (label1.Left > panel1.Size.Width && flagH == 0)
//            //{
//            //    label1.Left = label1.Left - paso;
//            //}


//        }

//    }
//}
/* for (int i = 0; i < 10; i++)
 {
     contador++;
     if (contador==10)
     {
         label1.Left += 1;
         i = 0;
     }

 }*/
