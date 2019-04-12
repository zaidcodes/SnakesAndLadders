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

        Button[] tableroBotones;

        Tablero tablero;

        Juego juego = new Juego();

        Label[] lblJugadores;

        Label[] lblPuntuacion;

        Rectangle[] crcJugadores;
        SolidBrush[] brochas;

        public IntPrincipal()
        {
            InitializeComponent();

            tablero = new Tablero();

            tableroBotones = tablero.TableroBotones;

            PanelTablero.Controls.AddRange(tableroBotones);

            lblJugadores = new Label[] { lblNomJug1, lblNomJug2, lblNomJug3, lblNomJug4 };

            lblPuntuacion = new Label[] { lblPuntJug1, lblPuntJug2, lblPuntJug3, lblPuntJug4 };

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
            configJuego.Show();

        }

        private void IntPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (juego.Jugadores != null)
            {
                for (int i = 0; i < juego.Jugadores.Length; i++)
                {
                    lblJugadores[i].Visible = true;
                    lblPuntuacion[i].Visible = true;
                    lblJugadores[i].Text = juego.Jugadores[i].Nombre;
                    InicializarPosJug();
                    Actualizar();
                }
            }
        }

        private void Actualizar()
        {
            for (int i = 0; i < juego.Jugadores.Length; i++)
            {
                lblPuntuacion[i].Text = juego.Jugadores[i].Posicion.ToString();
            }
            LblPruebas.Text = "Turno de " + juego.Jugadores[juego.EstadoJugador - 1].Nombre +
                "\nDado1 = " + juego.Dado1.Valor + " Dado2 = " + juego.Dado2.Valor;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            juego.Lanzar();
            juego.SiguienteJugador();
            Actualizar();
            //ActualizarPosJug();
            MoverUnaPosicion(0,PointSupIzq(tableroBotones[1].Location));
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

                    if (fin > inicio)
                    {
                        for (int k = inicio + 1; k <= fin; k++)
                        {
                            switch (i)
                            {
                                case 0:
                                    MoverUnaPosicion(i,PointSupIzq(tableroBotones[k].Location));
                                    break;
                                case 1:
                                    MoverUnaPosicion(i, PointSupDer(tableroBotones[k].Location));
                                    break;
                                case 2:
                                    MoverUnaPosicion(i, PointInfIzq(tableroBotones[k].Location));
                                    break;
                                case 3:
                                    MoverUnaPosicion(i, PointInfDer(tableroBotones[k].Location));
                                    break;
                            }
                        }
                    }
                    juego.Jugadores[i].PosicionActual = juego.Jugadores[i].Posicion;
                }
            }
        }

        public void MoverUnaPosicion(int jugador, Point destino)
        {
            for (int i = 0; i < 300; i++)
            {
                timer1.Start();
                crcJugadores[jugador].X += 1;
                Thread.Sleep(50);
            }
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
                        brochas[i] = new SolidBrush(Color.FromArgb(25, 118, 210)); //Azul
                        crcJugadores[i] = new Rectangle(PointSupIzq(tableroBotones[0].Location), crcTam);
                        break;
                    case 1:
                        brochas[i] = new SolidBrush(Color.FromArgb(100, 221, 23)); //Verde
                        crcJugadores[i] = new Rectangle(PointSupDer(tableroBotones[0].Location), crcTam);
                        break;
                    case 2:
                        brochas[i] = new SolidBrush(Color.FromArgb(229, 57, 53)); //Rojo
                        crcJugadores[i] = new Rectangle(PointInfIzq(tableroBotones[0].Location), crcTam);
                        break;
                    case 3:
                        brochas[i] = new SolidBrush(Color.FromArgb(255, 234, 0)); //Amarillo
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

    }
}
