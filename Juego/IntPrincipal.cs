using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            Pen lapiz = new Pen(Color.LawnGreen);

           

            graphics.DrawEllipse(lapiz, new RectangleF(new PointF(10, 10), new SizeF(30, 30)));

            graphics.Dispose();

            lapiz.Dispose();

        }

        private void IntPrincipal_Shown(object sender, EventArgs e)
        {
            IntConfigJuego configJuego = new IntConfigJuego(juego);
            configJuego.FormClosing += new FormClosingEventHandler(IntPrincipal_FormClosing);
            configJuego.Show();

        }

        private void IntPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int i = 0; i < juego.Jugadores.Length; i++)
            {
                lblJugadores[i].Visible = true;
                lblPuntuacion[i].Visible = true;
                lblJugadores[i].Text = juego.Jugadores[i].Nombre;
                Actualizar();
            }

        }

        public void Actualizar()
        {
            for (int i = 0; i < juego.Jugadores.Length; i++)
            {
                lblPuntuacion[i].Text = juego.Jugadores[i].Posicion.ToString();
            }
            LblPruebas.Text = "Turno de " + juego.Jugadores[juego.estadoJugador - 1].Nombre + 
                "\nDado1 = " + juego.Dado1.Valor + " Dado2 = " + juego.Dado2.Valor;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            juego.Lanzar();
            juego.SiguienteJugador();
            Actualizar();

            Graphics graphics = PanelTablero.CreateGraphics();

            Pen lapiz = new Pen(Color.LawnGreen);

            Random random = new Random();

            graphics.DrawEllipse(lapiz, new RectangleF(new PointF(random.Next(1,500), random.Next(1, 500)), new SizeF(random.Next(1, 200), random.Next(1, 300))));

        }
    }
}
