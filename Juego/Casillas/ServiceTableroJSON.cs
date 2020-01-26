using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Casillas {
    class ServiceTableroJSON : ServiceCasillasJSON{

        public static int GetCantidadTableros(string ruta) {

            string json = File.ReadAllText(ruta);

            var res = JsonConvert.DeserializeObject<dynamic>(json);
            Newtonsoft.Json.Linq.JArray tableros = res[nombreTableroJSON];
            int cantidadTableros = tableros.Count;


            return cantidadTableros;
        }        

    }
}
