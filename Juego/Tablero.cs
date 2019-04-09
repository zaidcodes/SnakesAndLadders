using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Juego
{
    public class Tablero
    {

        private Button[] tableroBotones;
        public Button[] TableroBotones { get => tableroBotones; set => tableroBotones = value; }

        public Tablero()
        {
            tableroBotones = new Button[100];
            CrearTablero();
        }

        public void CrearTablero()
        {
            int contX = 0;
            int contY = 9;
            int contCasilla = 0;
            bool dirBtn = true;
            for (int i = 0; i < 10; i++)
            {
                contX = (dirBtn) ? 0 : 9;
                for (int k = 0; k < 10; k++)
                {
                    tableroBotones[contCasilla] = new Button
                    {
                        Size = new Size(50, 50),
                        Location = new Point(((dirBtn) ? contX++ : contX--) * 50,
                        contY * 50),
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.CornflowerBlue,
                        Text = (contCasilla + 1).ToString()
                    };
                    contCasilla++;
                }
                dirBtn = !dirBtn;
                contY--;
            }
        }

        public void CrearSerpientes(Panel panel, PaintEventArgs e)
        {
            Graphics papel;

            Pen lapiz = new Pen(Color.Green);

            papel = e.Graphics;

            papel.DrawLine(lapiz, CentroInf(tableroBotones[99].Location), CentroSup(tableroBotones[9].Location));

            lapiz.Dispose();
            papel.Dispose();

        }

        private Point CentroInf(Point punto)
        {
            return new Point(punto.X + 25, punto.Y + 40);
        }

        private Point CentroSup(Point punto)
        {
            return new Point(punto.X + 25, punto.Y + 10);
        }

    }
}
