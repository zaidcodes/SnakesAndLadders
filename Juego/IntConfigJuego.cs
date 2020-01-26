using Juego.Casillas;
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

        private bool IsRandom = true;

        private int IdTablero = 0;

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

                if (!IsRandom) {
                    juego.IsRandomTab = false;
                    juego.IdTablero = IdTablero;
                }
                    
                juego.EleccionTablero();
                juego.GenerarObstaculos();
                Close();
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Establecer_CheckedChanged(object sender, EventArgs e) {
            if (ckEstablecerTab.Checked == true) {                
                cbEstablecerTablero.Visible = true;
                cbEstablecerTablero.Enabled = true;
                ckEstablecerTab.Enabled = false;
                ckRandomTab.Checked = false;
                string ruta = juego.RutaJSON;
                int cantidad = ServiceTableroJSON.GetCantidadTableros(ruta);

                cbEstablecerTablero.Items.Clear();
                for (int i = 1; i <= cantidad; i++) {
                    cbEstablecerTablero.Items.Add(i.ToString());
                }
                if (cbEstablecerTablero.Items.Count >0)
                    cbEstablecerTablero.SelectedIndex = 0;

                IsRandom = false;
            } else {
                ckEstablecerTab.Enabled = true;
                cbEstablecerTablero.Enabled = false;
                cbEstablecerTablero.Visible = false;
                IsRandom = true;
            }
        }

        private void Random_CheckedChanged(object sender, EventArgs e) {
            if (ckRandomTab.Checked == true) {
                ckRandomTab.Enabled = false;
                ckEstablecerTab.Checked = false;
                IsRandom = true;
            } else {
                ckRandomTab.Enabled = true;
                IsRandom = false;
            }
        }

        private void cbEstablecerTablero_SelectedIndexChanged(object sender, EventArgs e) {
            try {                
                IdTablero = (int) Convert.ToInt32(cbEstablecerTablero.Text);                
            }
            catch (Exception) {
                IsRandom = true;                
            }
        }
    }
}
