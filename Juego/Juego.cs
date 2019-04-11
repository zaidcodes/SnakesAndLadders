using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Juego
    {

        private Jugador[] jugadores;
        private Tablero tablero;
        private Dado dado1, dado2;
        public int estadoJugador;

        public Jugador[] Jugadores { get => jugadores; set => jugadores = value; }
        public Tablero Tablero { get => tablero; set => tablero = value; }
        public Dado Dado1 { get => dado1; set => dado1 = value; }
        public Dado Dado2 { get => dado2; set => dado2 = value; }

        public Juego()
        {
            tablero = new Tablero();
            dado1 = new Dado();
            dado2 = new Dado();
            estadoJugador = 1;
        }

        public void AgregarJugadores(Jugador[] jugadores)
        {
            this.jugadores = jugadores;
        }

        public void SiguienteJugador()
        {
            estadoJugador = (estadoJugador == jugadores.Length) ? 1 : estadoJugador + 1;
        }

        public void Lanzar()
        {
            int lanzamiento = jugadores[estadoJugador - 1].LanzarDados(dado1,dado2);

            jugadores[estadoJugador - 1].Avanzar(lanzamiento);

        }

    }
}
