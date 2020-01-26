using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Casillas {
    class ServiceRevertirSerntidoJSON : ServiceCasillasJSON{

        protected new static string nombreTipoCasillaJSON = "RevertirSentido";

        public static List<Obstaculo> GetRevertirSerntidoFromJSON(string ruta, int idTablero) {

            string json = File.ReadAllText(ruta);

            var res = JsonConvert.DeserializeObject<dynamic>(json);
            var tableros = res[nombreTableroJSON];
            var tablero = tableros[idTablero - 1];
            var casillas = tablero[nombreTipoCasillaJSON];

            List<Obstaculo> obstaculos = new List<Obstaculo>();

            foreach (var casilla in casillas) {
                obstaculos.Add(new RevertirSentido((int)casilla[nombreOrigenJSON]));
            }

            return obstaculos;
        }

    }
}
