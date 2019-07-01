using System;
using System.Windows.Forms;

namespace UI
{
    public enum Gamestate { Jugando, Detenido, Finalizado };
    public partial class Form2 : Form
    {
        Timer RelojAnimacionLeft = new Timer();
        Timer RelojAnimacionRight = new Timer();
        Timer RelojMoneda = new Timer();
        int contadormonedas = 0;
        public Gamestate EstadoJuego = Gamestate.Detenido;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            RelojAnimacionMoneda();
            
            if (EstadoJuego == Gamestate.Detenido)
            {
                

                if (e.KeyCode == Keys.Space)
                {
                    timerMoneda1.Start();
                    timerMoneda2.Start();
                    timerMoneda3.Start();
                    timerMoneda4.Start();
                    timerMoneda5.Start();
                    lblMoneda1.Visible = true;
                    lblMoneda2.Visible = true;
                    lblMoneda3.Visible = true;
                    lblMoneda4.Visible = true;
                    lblMoneda5.Visible = true;
                    EstadoJuego = Gamestate.Jugando;
                    
                    lblInformacion.Visible = false;
                    
                }
            }
            else if (EstadoJuego == Gamestate.Jugando)
            {
                
                AgarrandoMonedas();
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
                    if (lblNegro.Location.X < 779)
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
                if (contadormonedas == 25) //Subo velocidad
                {
                    timerMoneda1.Interval = +10;
                    timerMoneda2.Interval = +10;
                    timerMoneda3.Interval = +10;
                    timerMoneda4.Interval = +10;
                    timerMoneda5.Interval = +10;
                }
            }

        }
        /// <summary>
        /// Colision y Agarra Monedas con contador
        /// </summary>
        public void AgarrandoMonedas()
        {
            
            if (lblNegro.Bounds.IntersectsWith(lblMoneda1.Bounds))
            {
                
                contadormonedas++;
                
            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda2.Bounds))
            {
                contadormonedas++;
            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda3.Bounds))
            {
                contadormonedas++;
            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda4.Bounds))
            {
                contadormonedas++;
            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda5.Bounds))
            {
                contadormonedas++;
            }
            
            lblScore.Text = contadormonedas.ToString();
        }


        public void RelojAnimacionMoneda()
        {
            RelojMoneda.Interval = 300;
            RelojMoneda.Start();
            RelojMoneda.Tick += new EventHandler(AnimacionMoneda);

        }
        public void RelojAnimacionNegroLeft()
        {
            RelojAnimacionLeft.Interval = 50;
            RelojAnimacionLeft.Start();
            RelojAnimacionLeft.Tick += new EventHandler(AnimacionNegroLeft);

        }
        public void RelojAnimacionNegroRight()
        {
            RelojAnimacionRight.Interval = 50;
            RelojAnimacionRight.Start();
            RelojAnimacionRight.Tick += new EventHandler(AnimacionNegroRight);
        }
        public void AnimacionNegroRight(object sender, EventArgs e)
        {
            //if (lblNegro.ImageIndex < 6)
            //{
            //    lblNegro.ImageIndex = lblNegro.ImageIndex + 1;
            //}
            //else
            //{
            //    lblNegro.ImageIndex = 1;
            //}
        }
        public void AnimacionNegroLeft(object sender, EventArgs e)
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
        /// <summary>
        /// Animacion para las Monedas, Mostrando una nueva imagen de el list en cada intervalo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AnimacionMoneda(object sender, EventArgs e)
        {
            if (lblMoneda1.ImageIndex < 5 && lblMoneda2.ImageIndex < 5 && lblMoneda3.ImageIndex < 5 && lblMoneda4.ImageIndex < 5 && lblMoneda5.ImageIndex < 5)
            {
                lblMoneda1.ImageIndex = lblMoneda1.ImageIndex + 1;
                lblMoneda2.ImageIndex = lblMoneda2.ImageIndex + 1;
                lblMoneda3.ImageIndex = lblMoneda3.ImageIndex + 1;
                lblMoneda4.ImageIndex = lblMoneda4.ImageIndex + 1;
                lblMoneda5.ImageIndex = lblMoneda5.ImageIndex + 1;
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
                lblMoneda3.Left = lblMoneda3.Left - lblMoneda3.Right;
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
                lblMoneda5.Left = lblMoneda5.Left - ((posicionaleatoria.Next(0, 600)) + lblMoneda5.Right);
            }

        }
    }
}

