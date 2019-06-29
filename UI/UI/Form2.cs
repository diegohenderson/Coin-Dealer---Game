using System;
using System.Windows.Forms;

namespace UI
{
    public enum Gamestate { Jugando, Detenido, Finalizado };
    public partial class Form2 : Form
    {
        int flagHorizontal = 1;
        int flagVertical = 0;
        int movimiento = 10;
        private int direccion;
        Timer relojito = new Timer();
        Timer RelojAnimacionLeft = new Timer();
        Timer RelojMoneda = new Timer();
        public Gamestate EstadoJuego = Gamestate.Detenido;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void PnEscenario_Paint(object sender, PaintEventArgs e)
        {
        }
        private void LblNegro_Click(object sender, EventArgs e)
        {
            relojito.Interval = 50000;
            relojito.Start();
            relojito.Tick += new EventHandler(MovimientoPersonaje);

        }

        public void MovimientoPersonaje(object sender, EventArgs e)
        {
            //lblNegro.ImageIndex = 0;
            //if (lblNegro.Left + lblNegro.Width < pnEscenario.Width && flagHorizontal == 1)
            //{
            //    lblNegro.Left = lblNegro.Left + movimiento;
            //}
            //else
            //{
            //    flagHorizontal = -1;
            //    lblNegro.Left = lblNegro.Left - movimiento;
            //}
            //if (lblNegro.Left <= 0)
            //{
            //    flagHorizontal = 1;
            //}
            //if (lblNegro.Left > pnEscenario.Size.Width && flagHorizontal == 0)
            //{
            //    lblNegro.Left = lblNegro.Left - movimiento;
            //}




            ///////////
            //if (lblNegro.Left < pnEscenario.Size.Width && flagHorizontal == 1)
            //{
            //    lblNegro.Left = lblNegro.Left + movimiento;
            //}
            //else
            //{
            //    flagHorizontal = -1;
            //    lblNegro.Left = lblNegro.Left - movimiento;
            //    if (lblNegro.Left <= 0)
            //    {
            //        flagHorizontal = 1;
            //    }
            //}
        }




        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (EstadoJuego == Gamestate.Detenido)
            {
                
                //lblNegro.ImageIndex = 0;
                if (e.KeyCode == Keys.Space)
                {
                    EstadoJuego = Gamestate.Jugando;
                    RelojAnimacionMoneda();
                    lblInformacion.Visible = false;
                }
            }
            else if (EstadoJuego == Gamestate.Jugando)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (lblNegro.Location.X > 0)
                    {
                        lblNegro.Left = lblNegro.Left - 50;
                        RelojAnimacionNegroLeft();

                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (lblNegro.Location.X < 596)
                    {
                        lblNegro.Left = lblNegro.Left + 50;
                        RelojAnimacionLeft.Stop();

                    }
                }
                if (e.KeyCode == Keys.Up)
                {
                    lblNegro.Top = lblNegro.Top - 50;
                    RelojAnimacionLeft.Stop();

                }
                if (e.KeyCode == Keys.Down)
                {
                    lblNegro.Top = lblNegro.Top + 50;
                    RelojAnimacionLeft.Stop();
                }

            }

        }

        private void TimerAnimacion_Tick(object sender, EventArgs e)
        {

        }
        public void RelojAnimacionMoneda()
        {
            RelojMoneda.Interval = 500;
            RelojMoneda.Start();
            RelojMoneda.Tick += new EventHandler(AnimacionMoneda);

        }
        public void RelojAnimacionNegroLeft()
        {
            RelojAnimacionLeft.Interval = 50;
            RelojAnimacionLeft.Start();
            RelojAnimacionLeft.Tick += new EventHandler(AnimacionNegro);

        }
        public void AnimacionNegro(object sender, EventArgs e)
        {
            if (lblNegro.ImageIndex < 7)
            {
                lblNegro.ImageIndex = lblNegro.ImageIndex + 1;
            }
            else
            {
                lblNegro.ImageIndex = 1;
            }
        }
        public void AnimacionMoneda(object sender, EventArgs e)
        {
            if (lblMoneda1.ImageIndex < 6 && lblMoneda2.ImageIndex < 6 && lblMoneda3.ImageIndex < 6 && lblMoneda4.ImageIndex < 6 && lblMoneda5.ImageIndex < 6)
            {
                lblMoneda1.ImageIndex = lblMoneda1.ImageIndex + 2;
                lblMoneda2.ImageIndex = lblMoneda2.ImageIndex + 2;
                lblMoneda3.ImageIndex = lblMoneda3.ImageIndex + 2;
                lblMoneda4.ImageIndex = lblMoneda4.ImageIndex + 2;
                lblMoneda5.ImageIndex = lblMoneda5.ImageIndex + 2;
            }
            else
            {
                lblMoneda1.ImageIndex = 1;
                lblMoneda2.ImageIndex = 1;
                lblMoneda3.ImageIndex = 1;
                lblMoneda4.ImageIndex = 1;
                lblMoneda5.ImageIndex = 1;
            }
        }
        /// <summary>
        /// Timer para Monedas con su Timer Correspondiente
        /// 
        /// </summary>
        /// <param lblMoneda1="sender"></param>
        /// <param TimerMoneda1_Tick="e"></param>
        private void TimerMoneda1_Tick(object sender, EventArgs e)
        {
            lblMoneda1.Left = lblMoneda1.Left + 1;
            if (lblMoneda1.Left >= pnEscenario.Width)
            {
                lblMoneda1.Left = lblMoneda1.Left - lblMoneda1.Right;
            }
        }

        private void TimerMoneda2_Tick(object sender, EventArgs e)
        {
            lblMoneda2.Left = lblMoneda2.Left + 2;
            if (lblMoneda2.Left >= pnEscenario.Width)
            {
                lblMoneda2.Left = lblMoneda2.Left - lblMoneda2.Right;
            }

        }

        private void TimerMoneda3_Tick(object sender, EventArgs e)
        {
            lblMoneda3.Left = lblMoneda3.Left + 3;
            if (lblMoneda3.Left >= pnEscenario.Width)
            {
                lblMoneda3.Left =  lblMoneda3.Left- lblMoneda3.Right;
            }

        }

        private void TimerMoneda4_Tick(object sender, EventArgs e)
        {
            lblMoneda4.Left = lblMoneda4.Left + 4;
            if (lblMoneda4.Left >= pnEscenario.Width)
            {
                lblMoneda4.Left = lblMoneda4.Left - lblMoneda4.Right;
            }

        }

        private void TimerMoneda5_Tick(object sender, EventArgs e)
        {
            lblMoneda5.Left = lblMoneda5.Left + 5;
            if (lblMoneda5.Left >= pnEscenario.Width)
            {
                Random posicionaleatoria = new Random();
                lblMoneda5.Left = lblMoneda5.Left - ((posicionaleatoria.Next(0,600)) + lblMoneda5.Right) ; 
            }

        }
    }
}


//private void controlLimites(int flagHorizontal, int flagVertical)
//{
//    if (flagHorizontal < 1)
//    {
//        direccion = 1;
//    }
//    else
//    {
//        direccion = -1;
//    }
//}

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
