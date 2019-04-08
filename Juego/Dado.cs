using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Dado
    {

        private int valor;
        private Random random;

        public int Valor { get => valor; set => valor = value; }

        public Dado()
        {
            Valor = 0;
            random = new Random();
        }

        public void Caer()
        {
            Valor = random.Next(1, 7);
        }

    }
}
