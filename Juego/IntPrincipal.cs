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

        public IntPrincipal()
        {
            InitializeComponent();

            Tablero tablero = new Tablero();

            tableroBotones = tablero.TableroBotones;

            PanelTablero.Controls.AddRange(tableroBotones);

        }

    }
}
