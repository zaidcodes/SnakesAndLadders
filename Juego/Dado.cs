using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Dado
    {

        private int valor;
        private static Random random = new Random();

        public int Valor { get => valor; set => valor = value; }

        public Dado()
        {
            Valor = 0;
        }

        public void Caer()
        {
            Valor = random.Next(1, 7);
        }

        public static int operator +(Dado dado1, Dado dado2)
        {
            return dado1.Valor + dado2.Valor;
        }

    }
}
