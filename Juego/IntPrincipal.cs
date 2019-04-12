using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class IntPrincipal : Form
    {
        Boolean PrimeraVez = true;

        Button[] tableroBotones;

        Tablero tablero;

        Juego juego = new Juego();

        Label[] lblJugadores;

        Label[] lblPuntuacion;

        Rectangle[] crcJugadores;
        SolidBrush[] brochas;
        Color[] colores;

        Color Azul;
        Color Verde;
        Color Rojo;
        Color Amarillo;

        public IntPrincipal()
        {
            InitializeComponent();

            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            CenterToScreen();

            Azul = Color.FromArgb(255, 253, 231);
            Verde = Color.FromArgb(100, 221, 23);
            Rojo = Color.FromArgb(229, 57, 53);
            Amarillo = Color.FromArgb(255, 234, 0);

            tablero = new Tablero();

            tableroBotones = tablero.TableroBotones;

            //PanelTablero.Controls.AddRange(tableroBotones);

            lblJugadores = new Label[] { lblNomJug1, lblNomJug2, lblNomJug3, lblNomJug4 };

            lblPuntuacion = new Label[] { lblPuntJug1, lblPuntJug2, lblPuntJug3, lblPuntJug4 };

            colores = new Color[] {Azul, Verde, Rojo, Amarillo};
        }

        private void PanelTablero_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            for (int i = 0; i < juego.CantJugadores; i++)
            {
                graphics.FillEllipse(brochas[i], crcJugadores[i]);
            }

        }

        private void IntPrincipal_Shown(object sender, EventArgs e)
        {
            IntConfigJuego configJuego = new IntConfigJuego(juego);
            configJuego.FormClosing += new FormClosingEventHandler(IntPrincipal_FormClosing);
            configJuego.ShowDialog();

        }

        private void IntPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (juego.Jugadores != null)
            {
                btnLanzar.ForeColor = colores[0];
                lblJugador.Visible = true;
                lblPosicion.Visible = true;
                btnLanzar.Visible = true;
                LblPruebas.Visible = true;
                btnIniciar.Visible = false;

                for (int i = 0; i < juego.Jugadores.Length; i++)
                {
                    lblJugadores[i].ForeColor = colores[i];
                    lblPuntuacion[i].ForeColor = colores[i];
                    lblJugadores[i].Visible = true;
                    lblPuntuacion[i].Visible = true;
                    lblJugadores[i].Text = juego.Jugadores[i].Nombre;
                    
                }
                InicializarPosJug();
                Actualizar();
            }
        }

        private void Actualizar()
        {
            for (int i = 0; i < juego.Jugadores.Length; i++)
            {
                lblPuntuacion[i].Text = juego.Jugadores[i].Posicion.ToString();
            }
            LblPruebas.Text = "Turno Actual\n" + juego.Jugadores[juego.EstadoJugador - 1].Nombre;

            btnLanzar.ForeColor = colores[juego.EstadoJugador - 1];

            lblSuma.Text = "Suma = " + (juego.Dado1.Valor + juego.Dado2.Valor);

            MostrarDados();

            if(!PrimeraVez)
            {
                lblDetalles.Text = "Tiro de " + ((juego.EstadoJugador == 1) ? 
                    juego.Jugadores[juego.CantJugadores - 1].Nombre : 
                    juego.Jugadores[juego.EstadoJugador - 2].Nombre) + " - Detalles";
            } else
            {
                lblDetalles.Text = "";
                PrimeraVez = !PrimeraVez;
            }

        }

        private void MostrarDados()
        {
            switch(juego.Dado1.Valor)
            {
                case 1:
                    pic1Dado1.Visible = false;
                    pic2Dado1.Visible = false;
                    pic3Dado1.Visible = false;
                    pic4Dado1.Visible = true;
                    pic5Dado1.Visible = false;
                    pic6Dado1.Visible = false;
                    pic7Dado1.Visible = false;
                    break;
                case 2:
                    pic1Dado1.Visible = false;
                    pic2Dado1.Visible = true;
                    pic3Dado1.Visible = false;
                    pic4Dado1.Visible = false;
                    pic5Dado1.Visible = false;
                    pic6Dado1.Visible = true;
                    pic7Dado1.Visible = false;
                    break;
                case 3:
                    pic1Dado1.Visible = false;
                    pic2Dado1.Visible = false;
                    pic3Dado1.Visible = true;
                    pic4Dado1.Visible = true;
                    pic5Dado1.Visible = true;
                    pic6Dado1.Visible = false;
                    pic7Dado1.Visible = false;
                    break;
                case 4:
                    pic1Dado1.Visible = true;
                    pic2Dado1.Visible = false;
                    pic3Dado1.Visible = true;
                    pic4Dado1.Visible = false;
                    pic5Dado1.Visible = true;
                    pic6Dado1.Visible = false;
                    pic7Dado1.Visible = true;
                    break;
                case 5:
                    pic1Dado1.Visible = true;
                    pic2Dado1.Visible = false;
                    pic3Dado1.Visible = true;
                    pic4Dado1.Visible = true;
                    pic5Dado1.Visible = true;
                    pic6Dado1.Visible = false;
                    pic7Dado1.Visible = true;
                    break;
                case 6:
                    pic1Dado1.Visible = true;
                    pic2Dado1.Visible = true;
                    pic3Dado1.Visible = true;
                    pic4Dado1.Visible = false;
                    pic5Dado1.Visible = true;
                    pic6Dado1.Visible = true;
                    pic7Dado1.Visible = true;
                    break;
            }

            switch (juego.Dado2.Valor)
            {
                case 1:
                    pic1Dado2.Visible = false;
                    pic2Dado2.Visible = false;
                    pic3Dado2.Visible = false;
                    pic4Dado2.Visible = true;
                    pic5Dado2.Visible = false;
                    pic6Dado2.Visible = false;
                    pic7Dado2.Visible = false;
                    break;
                case 2:
                    pic1Dado2.Visible = false;
                    pic2Dado2.Visible = true;
                    pic3Dado2.Visible = false;
                    pic4Dado2.Visible = false;
                    pic5Dado2.Visible = false;
                    pic6Dado2.Visible = true;
                    pic7Dado2.Visible = false;
                    break;
                case 3:
                    pic1Dado2.Visible = false;
                    pic2Dado2.Visible = false;
                    pic3Dado2.Visible = true;
                    pic4Dado2.Visible = true;
                    pic5Dado2.Visible = true;
                    pic6Dado2.Visible = false;
                    pic7Dado2.Visible = false;
                    break;
                case 4:
                    pic1Dado2.Visible = true;
                    pic2Dado2.Visible = false;
                    pic3Dado2.Visible = true;
                    pic4Dado2.Visible = false;
                    pic5Dado2.Visible = true;
                    pic6Dado2.Visible = false;
                    pic7Dado2.Visible = true;
                    break;
                case 5:
                    pic1Dado2.Visible = true;
                    pic2Dado2.Visible = false;
                    pic3Dado2.Visible = true;
                    pic4Dado2.Visible = true;
                    pic5Dado2.Visible = true;
                    pic6Dado2.Visible = false;
                    pic7Dado2.Visible = true;
                    break;
                case 6:
                    pic1Dado2.Visible = true;
                    pic2Dado2.Visible = true;
                    pic3Dado2.Visible = true;
                    pic4Dado2.Visible = false;
                    pic5Dado2.Visible = true;
                    pic6Dado2.Visible = true;
                    pic7Dado2.Visible = true;
                    break;
            }

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            lblSuma.Visible = true;
            lblDetalles.Visible = true;
            picDado1.Visible = true;
            picDado2.Visible = true;

            juego.Lanzar();
            juego.VerificarCasilla();
            juego.SiguienteJugador();
            Actualizar();
            ActualizarPosJug();
            VerificarGanador();
            //MoverUnaPosicion(0,PointSupIzq(tableroBotones[1].Location));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void ActualizarPosJug()
        {
            int inicio;
            int fin;
            for (int i = 0; i < juego.CantJugadores; i++)
            {
                if(juego.Jugadores[i].PosicionActual != juego.Jugadores[i].Posicion)
                {
                    inicio = juego.Jugadores[i].PosicionActual - 1;
                    fin = juego.Jugadores[i].Posicion - 1;

                    //if (fin > inicio)
                    //{
                    //    for (int k = inicio + 1; k <= fin; k++)
                    //    {
                    switch (i)
                    {
                        case 0:
                            MoverAPosicion(i, PointSupIzq(tableroBotones[fin].Location));
                            break;
                        case 1:
                            MoverAPosicion(i, PointSupDer(tableroBotones[fin].Location));
                            break;
                        case 2:
                            MoverAPosicion(i, PointInfIzq(tableroBotones[fin].Location));
                            break;
                        case 3:
                            MoverAPosicion(i, PointInfDer(tableroBotones[fin].Location));
                            break;
                    }
                    //    }
                    //}
                    juego.Jugadores[i].PosicionActual = juego.Jugadores[i].Posicion;
                }
            }
        }

        public void MoverUnaPosicion(int jugador, Point destino)
        {
            //for (int i = 0; i < 300; i++)
            //{
            //    timer1.Start();
            //    crcJugadores[jugador].X += 1;
            //    Thread.Sleep(50);
            //}
            /*while (crcJugadores[jugador].X != destino.X && crcJugadores[jugador].Y != destino.Y)
            {
                if (crcJugadores[jugador].X < destino.X)
                    crcJugadores[jugador].X += 1;
                else
                    crcJugadores[jugador].X -= 1;

                if (crcJugadores[jugador].Y < destino.Y)
                    crcJugadores[jugador].Y += 1;
                else
                    crcJugadores[jugador].Y -= 1;
                
            }*/
        }

        public void MoverAPosicion(int jugador, Point destino)
        {
            crcJugadores[jugador].Location = destino;
        }

        private void InicializarPosJug()
        {
            crcJugadores = new Rectangle[juego.CantJugadores];
            brochas = new SolidBrush[juego.CantJugadores];

            Size crcTam = new Size(12, 12);

            for (int i = 0; i < juego.CantJugadores; i++)
            {
                switch(i)
                {
                    case 0:
                        brochas[i] = new SolidBrush(Azul); //Azul
                        crcJugadores[i] = new Rectangle(PointSupIzq(tableroBotones[0].Location), crcTam);
                        break;
                    case 1:
                        brochas[i] = new SolidBrush(Verde); //Verde
                        crcJugadores[i] = new Rectangle(PointSupDer(tableroBotones[0].Location), crcTam);
                        break;
                    case 2:
                        brochas[i] = new SolidBrush(Rojo); //Rojo
                        crcJugadores[i] = new Rectangle(PointInfIzq(tableroBotones[0].Location), crcTam);
                        break;
                    case 3:
                        brochas[i] = new SolidBrush(Amarillo); //Amarillo
                        crcJugadores[i] = new Rectangle(PointInfDer(tableroBotones[0].Location), crcTam);
                        break;
                }
            }
        }

        private Point PointSupIzq(Point point)
        {
            return new Point(point.X + 5,point.Y + 5);
        }

        private Point PointSupDer(Point point)
        {
            return new Point(point.X + 33, point.Y + 5);
        }

        private Point PointInfIzq(Point point)
        {
            return new Point(point.X + 5, point.Y + 33);
        }

        private Point PointInfDer(Point point)
        {
            return new Point(point.X + 33, point.Y + 33);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IntConfigJuego configJuego = new IntConfigJuego(juego);
            configJuego.FormClosing += new FormClosingEventHandler(IntPrincipal_FormClosing);
            configJuego.ShowDialog();
        }

        private void VerificarGanador()
        {
            for(int i = 0; i < juego.CantJugadores; i++)
            {
                if (juego.Jugadores[i].Posicion == 100)
                {
                    DialogResult resultGanador = MessageBox.Show(juego.Ganador(juego.Jugadores[i]),
                        "Juego finalizado",MessageBoxButtons.OK,MessageBoxIcon.None);

                    if(resultGanador == DialogResult.OK)
                    {
                        DialogResult resultSalir = MessageBox.Show("¿Desea volver a jugar? En caso contrario se cerrará el juego.", "Aviso",
                            MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (resultSalir == DialogResult.No)
                        {
                            Close();
                        }
                        else if (resultSalir == DialogResult.Yes)
                        {
                            Reiniciar();
                        }

                    }

                }
            }
        }

        private void Reiniciar()
        {
            juego = new Juego();

            PrimeraVez = true;

            lblJugador.Visible = false;
            lblPosicion.Visible = false;
            lblNomJug1.Visible = false;
            lblNomJug2.Visible = false;
            lblNomJug3.Visible = false;
            lblNomJug4.Visible = false;
            lblPuntJug1.Visible = false;
            lblPuntJug2.Visible = false;
            lblPuntJug3.Visible = false;
            lblPuntJug4.Visible = false;
            LblPruebas.Visible = false;
            lblDetalles.Visible = false;
            lblSuma.Visible = false;

            btnLanzar.Visible = false;
            btnIniciar.Visible = true;

            picDado1.Visible = false;
            picDado2.Visible = false;

            pic1Dado1.Visible = false;
            pic2Dado1.Visible = false;
            pic3Dado1.Visible = false;
            pic4Dado1.Visible = false;
            pic5Dado1.Visible = false;
            pic6Dado1.Visible = false;
            pic7Dado1.Visible = false;

            pic1Dado2.Visible = false;
            pic2Dado2.Visible = false;
            pic3Dado2.Visible = false;
            pic4Dado2.Visible = false;
            pic5Dado2.Visible = false;
            pic6Dado2.Visible = false;
            pic7Dado2.Visible = false;

            IntConfigJuego configJuego = new IntConfigJuego(juego);
            configJuego.FormClosing += new FormClosingEventHandler(IntPrincipal_FormClosing);
            configJuego.ShowDialog();

        }

    }
}
