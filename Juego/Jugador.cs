using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{

    public class Jugador
    {

        private String nombre;
        private int posicion;
        private int posicionActual;

        public int Posicion { get => posicion; set => posicion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PosicionActual { get => posicionActual; set => posicionActual = value; }

        public Jugador(String nombre)
        {
            this.nombre = nombre;
            posicion = 1;
            posicionActual = 1;
        }

        public void Avanzar(int posiciones)
        {
            posicion += posiciones;
        }

        public void Retroceder(int posicion)
        {
            this.posicion = posicion;
        }

        public int LanzarDados(Dado dado1, Dado dado2)
        {
            dado1.Caer();
            dado2.Caer();

            return dado1 + dado2;

        }

    }
}
