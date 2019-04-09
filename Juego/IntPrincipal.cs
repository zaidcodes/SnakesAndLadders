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

        public IntPrincipal()
        {
            InitializeComponent();

            tablero = new Tablero();

            tableroBotones = tablero.TableroBotones;

            PanelTablero.Controls.AddRange(tableroBotones);

            LblPruebas.Text = tableroBotones[99].Location.X + "," + tableroBotones[99].Location.Y;

        }

        private void PanelTablero_Paint(object sender, PaintEventArgs e)
        {
            tablero.CrearSerpientes(sender as Panel, e);
        }

        private void IntPrincipal_Shown(object sender, EventArgs e)
        {
            IntConfigJuego configJuego = new IntConfigJuego(juego);

            configJuego.Show();

        }
        
    }
}
