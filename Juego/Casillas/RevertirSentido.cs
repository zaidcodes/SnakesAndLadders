using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Casillas {
    class RevertirSentido : Obstaculo {

        private new int destino;

        public RevertirSentido(int Origen) {
            this.Origen = Origen;
        }

        protected override int GetDestino() {
            throw new DestinoException();
        }

        protected override void SetDestino(int value) {
            throw new DestinoException();
        }

        public override bool VerificarCasilla(Juego juego, Jugador jugador) {
            bool isInOrigin = false;
            if (jugador.Posicion == Origen) {
                juego.CambiarSentido();
                isInOrigin = true;
            }
            return isInOrigin;
        }

        private class DestinoException : Exception {
            public DestinoException() : base("Revertir sentido no contiene una casilla destino") { }
        }

    }
}
