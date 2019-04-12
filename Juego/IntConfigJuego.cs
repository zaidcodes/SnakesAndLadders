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
    public partial class IntConfigJuego : Form
    {

        private Juego juego;

        private int cantJugadores = 2;

        private TextBox[] txtBoxJugadores;

        public IntConfigJuego(Juego juego)
        {
            InitializeComponent();
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            CenterToParent();
            txtBoxJugadores = new TextBox[] {txtBox1Jugador,txtBox2Jugador,txtBox3Jugador,txtBox4Jugador};
            this.juego = juego;
        }

        private void Add3Jugador_Click(object sender, EventArgs e)
        {
            txtBox3Jugador.Visible = true;
            Add3Jugador.Visible = false;
            Add4Jugador.Visible = true;
            Del3Jugador.Visible = true;

            cantJugadores++;
        }

        private void Add4Jugador_Click(object sender, EventArgs e)
        {
            txtBox4Jugador.Visible = true;
            Add4Jugador.Visible = false;
            Del3Jugador.Visible = false;
            Del4Jugador.Visible = true;

            cantJugadores++;
        }

        private void Del4Jugador_Click(object sender, EventArgs e)
        {
            Del4Jugador.Visible = false;
            txtBox4Jugador.Visible = false;
            Add4Jugador.Visible = true;
            Del3Jugador.Visible = true;

            txtBox4Jugador.Text = "";

            cantJugadores--;
        }

        private void Del3Jugador_Click(object sender, EventArgs e)
        {
            Del3Jugador.Visible = false;
            Add4Jugador.Visible = false;
            txtBox3Jugador.Visible = false;
            Add3Jugador.Visible = true;

            txtBox3Jugador.Text = "";

            cantJugadores--;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Jugador[] jugadores = new Jugador[cantJugadores];

            bool CampoLleno = true;

            for (int i = 0; i < cantJugadores; i++)
                if (txtBoxJugadores[i].Text == "")
                    CampoLleno = false;

            if (CampoLleno)
            {
                for(int i = 0; i < cantJugadores; i++)
                    jugadores[i] = new Jugador(txtBoxJugadores[i].Text);

                juego.AgregarJugadores(jugadores);
                Close();
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
