using Juego.Casillas;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego {
    public class Juego {

        private Jugador[] jugadores;
        private Tablero tablero;
        private Dado dado1, dado2;
        private int estadoJugador;
        public int CantJugadores;
        private List<Obstaculo> Obstaculos = new List<Obstaculo>();
        private bool SentidoAscendente = true; //true: 1,2,3,4 false: 4,3,2,1
        private readonly string rutaJSON = "..\\..\\JSON\\Tableros.json";

        public string RutaJSON {
            get { return rutaJSON; }         
        }
        
        private bool isRandomTab = true;

        public bool IsRandomTab {
            get { return isRandomTab; }
            set { isRandomTab = value; }
        }

        public int IdTablero { get; set; }


        public Jugador[] Jugadores { get => jugadores; set => jugadores = value; }
        public Tablero Tablero { get => tablero; set => tablero = value; }
        public Dado Dado1 { get => dado1; set => dado1 = value; }
        public Dado Dado2 { get => dado2; set => dado2 = value; }
        public int EstadoJugador { get => estadoJugador; set => estadoJugador = value; }

        public Juego() {
            tablero = new Tablero();
            dado1 = new Dado();
            dado2 = new Dado();
            estadoJugador = 1;

            //EleccionTablero();
            //GenerarObstaculos();

        }

        public void EleccionTablero() {
            if (isRandomTab) 
                TableroRandomGen();                            
        }

        private void TableroRandomGen() {
            Random random = new Random();
            int cantidadTableros = ServiceTableroJSON.GetCantidadTableros(RutaJSON);
            IdTablero = random.Next(1, cantidadTableros + 1);
        }

        public void AgregarJugadores(Jugador[] jugadores) {
            this.jugadores = jugadores;
            CantJugadores = this.jugadores.Length;
        }

        public void SiguienteJugador() {
            if (SentidoAscendente) {
                estadoJugador = (estadoJugador == jugadores.Length) ? 1 : estadoJugador + 1;
            } else {
                estadoJugador = (estadoJugador == 1) ? jugadores.Length : estadoJugador - 1;
            }
        }

        public void Lanzar() {
            int lanzamiento = jugadores[estadoJugador - 1].LanzarDados(dado1, dado2);

            jugadores[estadoJugador - 1].Avanzar(lanzamiento);

        }

        public void VerificarCasilla() {
            Jugador jugador = jugadores[estadoJugador - 1];
            foreach (Obstaculo obstaculo in Obstaculos) {
                //Descomentar el siguiente "if" si solo quiere establecer un tipo de casilla por casilla, valga la redundancia.
                //if (obstaculo.VerificarCasilla(this, jugador) == true)
                //    break;
                obstaculo.VerificarCasilla(this, jugador);
            }
        }

        public void GenerarObstaculos() {            
            Obstaculos.AddRange(ServiceRevertirSerntidoJSON.GetRevertirSerntidoFromJSON(RutaJSON, IdTablero));
            Obstaculos.AddRange(ServiceEscaleraJSON.GetEscalerasFromJSON(RutaJSON, IdTablero));
            Obstaculos.AddRange(ServiceSerpienteJSON.GetSerpientesFromJSON(RutaJSON, IdTablero));
        }

        public void CambiarSentido() {
            SentidoAscendente = (SentidoAscendente == true) ? false : true;
        }

        public String Ganador(Jugador jugador) {
            return "¡Felicidades " + jugador.Nombre + " has ganado la partida!";
        }

    }
}
