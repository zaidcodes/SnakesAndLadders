using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Casillas {
    abstract class Obstaculo {

        protected int Origen { get; set; }
        protected int Destino { get; set; }

        protected virtual int GetDestino() {
            return Destino;
        }

        protected virtual void SetDestino(int value) {
            Destino = value;
        }

        public abstract bool VerificarCasilla(Juego juego ,Jugador jugador);


    }
}
