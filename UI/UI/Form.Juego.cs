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
        Random RandomPosicionX = new Random();
        Random RandomPosicionY = new Random();
        public Gamestate EstadoJuego = Gamestate.Detenido;
        private int posX;
        private int posY;
        int tiempoRestante = 30;
        int contadoranimacion;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RelojAnimacionNegro();
        }
        public void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            RelojAnimacionMoneda();

            if (EstadoJuego == Gamestate.Detenido)
            {


                if (e.KeyCode == Keys.Space)
                {
                    timerMonedas.Start();
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
                timerTiempo.Start();
                
                if (e.KeyCode == Keys.Left)
                {
                    if (lblNegro.Location.X > 0)
                    {
                        lblNegro.Left = lblNegro.Left - 50;
                        
                        
                        AgarrandoMonedas();
                        lblNegro.ImageList = imageListNegroLeft;
                    }
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (lblNegro.Location.X < 779)
                    {
                        lblNegro.Left = lblNegro.Left + 50;
                        
                        
                        lblNegro.ImageList = imageListNegroRight;
                        AgarrandoMonedas();
                    }
                }
                if (e.KeyCode == Keys.Space)
                {
                    if (lblNegro.Location.Y > 250)
                    {
                        lblNegro.Top = lblNegro.Top - 50;

                        AgarrandoMonedas();

                    }
                    
                }
                if (e.KeyCode == Keys.Down)
                {
                    if( lblNegro.Location.Y < 250)
                    {
                    lblNegro.Top = lblNegro.Top + 50;
                    
                    AgarrandoMonedas();

                    }
                }
                if (contadormonedas == 25) //Subo velocidad
                {
                    //timerMoneda1.Interval += 10;

                    timerMonedas.Interval = +10;
                }
            }
            if (EstadoJuego == Gamestate.Detenido)
            {
                lblGameOver.Visible = true;
                lblTiempo.Show();
                timerMonedas.Stop();
                RelojAnimacionLeft.Stop();
                RelojMoneda.Stop();
            }
        }
        /// <summary>
        /// Colision entre los lblMonedas y LblNegro, con contador
        /// </summary>
        public void AgarrandoMonedas()
        {

            if (lblNegro.Bounds.IntersectsWith(lblMoneda1.Bounds))
            {
                lblMoneda1.Visible = false;
                contadormonedas++;
                

            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda2.Bounds))
            {
                lblMoneda2.Visible = false;
                contadormonedas++;
                
            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda3.Bounds))
            {
                lblMoneda3.Visible = false;
                contadormonedas++;
                
            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda4.Bounds))
            {
                lblMoneda4.Visible = false;
                contadormonedas++;
                
            }
            else if (lblNegro.Bounds.IntersectsWith(lblMoneda5.Bounds))
            {
                lblMoneda5.Visible = false;
                contadormonedas++;
            }

            lblScore.Text = contadormonedas.ToString();
        }

        /// <summary>
        /// reloj para la animacion de las monedas
        /// </summary>
        public void RelojAnimacionMoneda()
        {
            RelojMoneda.Interval = 300;
            RelojMoneda.Start();
            RelojMoneda.Tick += new EventHandler(AnimacionMoneda);

        }
        /// <summary>
        /// reloj para la animacion de el negro
        /// </summary>
        public void RelojAnimacionNegro()
        {
            RelojAnimacionLeft.Interval = 200;
            RelojAnimacionLeft.Start();
            RelojAnimacionLeft.Tick += new EventHandler(AnimacionNegro);

        }
        /// <summary>
        /// Animacion Personaje, Responde a el metodo RelojAnimacionNegro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AnimacionNegro(object sender, EventArgs e)
        {

            if (lblNegro.ImageIndex == lblNegro.ImageList.Images.Count-1)
            {
                lblNegro.ImageIndex=0;
            }
            else
            {
                lblNegro.ImageIndex++;
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
        /// Timer para Monedas, posicion, lugar,colision con su Timer Correspondiente
        /// </summary>
        
        private void TimerMoneda1_Tick(object sender, EventArgs e)
        {
            lblMoneda1.Left = lblMoneda1.Left + 1;
            if (lblMoneda1.Left >= pnEscenario.Width || lblNegro.Bounds.IntersectsWith(lblMoneda1.Bounds))
            {
                posX = RandomPosicionX.Next(0, 779);
                posY = RandomPosicionY.Next(150, 512);
                lblMoneda1.Location = new System.Drawing.Point(posX, posY);
                lblMoneda1.Visible = true;
            }
            
            ///
            lblMoneda2.Left = lblMoneda2.Left + 2;
            if (lblMoneda2.Left >= pnEscenario.Width || lblNegro.Bounds.IntersectsWith(lblMoneda2.Bounds))
            {
                posX = RandomPosicionX.Next(0, 779);
                posY = RandomPosicionY.Next(150, 512);
                lblMoneda2.Location = new System.Drawing.Point(posX, posY);
                lblMoneda2.Visible = true;
            }
            ///
            lblMoneda3.Left = lblMoneda3.Left + 3;
            if (lblMoneda3.Left >= pnEscenario.Width || lblNegro.Bounds.IntersectsWith(lblMoneda3.Bounds))
            {
                posX = RandomPosicionX.Next(0, 779);
                posY = RandomPosicionY.Next(150, 512);
                lblMoneda3.Location = new System.Drawing.Point(posX, posY);
                lblMoneda3.Visible = true;
            }
            ///
            lblMoneda4.Left = lblMoneda4.Left + 4;
            if (lblMoneda4.Left >= pnEscenario.Width || lblNegro.Bounds.IntersectsWith(lblMoneda4.Bounds))
            {
                posX = RandomPosicionX.Next(0, 779);
                posY = RandomPosicionY.Next(150, 512);
                lblMoneda4.Location = new System.Drawing.Point(posX, posY);
                lblMoneda4.Visible = true;
            }
            ///
            lblMoneda5.Left = lblMoneda5.Left + 5;
            if (lblMoneda5.Left >= pnEscenario.Width || lblNegro.Bounds.IntersectsWith(lblMoneda5.Bounds))
            {
                posX = RandomPosicionX.Next(0, 779);
                posY = RandomPosicionY.Next(150, 512);
                lblMoneda5.Location = new System.Drawing.Point(posX, posY);
                lblMoneda5.Visible = true;
            }
        }




        
        /// <summary>
        /// reloj para el tiempo restante, objetivo de el juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TimerTiempo_Tick(object sender, EventArgs e)
        {
            tiempoRestante = tiempoRestante - 1;
            lblTiempo.Text = "time left: " + tiempoRestante.ToString();
            if (tiempoRestante < 1)
            {
                timerTiempo.Stop();
                
                EstadoJuego = Gamestate.Detenido;
            }

        }
    }
}

