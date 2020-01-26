using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Casillas {
    class Serpiente : Obstaculo {

        public Serpiente(int Origen, int Destino) {
            this.Origen = Origen;
            this.Destino = Destino;
        }

        public override bool VerificarCasilla(Juego juego, Jugador jugador) {
            bool isInOrigin = false;
            if (jugador.Posicion == Origen) {
                jugador.Descender(Destino);
                isInOrigin = true;
            }
            return isInOrigin;
        }
    }
}
