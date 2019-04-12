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
        private int estadoJugador;
        public int CantJugadores;
        private int[] SerpientesOrigen;
        private int[] SerpientesDestino;
        private int[] EscalerasOrigen;
        private int[] EscalerasDestino;


        public Jugador[] Jugadores { get => jugadores; set => jugadores = value; }
        public Tablero Tablero { get => tablero; set => tablero = value; }
        public Dado Dado1 { get => dado1; set => dado1 = value; }
        public Dado Dado2 { get => dado2; set => dado2 = value; }
        public int EstadoJugador { get => estadoJugador; set => estadoJugador = value; }

        public Juego()
        {
            tablero = new Tablero();
            dado1 = new Dado();
            dado2 = new Dado();
            estadoJugador = 1;
            SerpientesOrigen = new int[] {99, 88, 60, 53, 36};
            SerpientesDestino = new int[] {65, 51, 29, 3, 5};
            EscalerasOrigen = new int[] {8, 30, 38, 66, 56};
            EscalerasDestino = new int[] {34, 70, 62, 91, 82};
        }

        public void AgregarJugadores(Jugador[] jugadores)
        {
            this.jugadores = jugadores;
            CantJugadores = this.jugadores.Length;
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

        public void VerificarCasilla()
        {
            for (int i = 0; i < 5; i++)
            {
                if(SerpientesOrigen[i] == jugadores[estadoJugador - 1].Posicion)
                {
                    jugadores[estadoJugador - 1].Descender(SerpientesDestino[i]);
                    break;
                }
                if(EscalerasOrigen[i] == jugadores[estadoJugador - 1].Posicion)
                {
                    jugadores[estadoJugador - 1].Ascender(EscalerasDestino[i]);
                    break;
                }
            }
        }

        public String Ganador(Jugador jugador)
        {
            return "¡Felicidades " + jugador.Nombre + " has ganado la partida!";
        }

    }
}
