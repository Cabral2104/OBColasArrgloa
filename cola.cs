using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBColasArrgloa
{
    internal class Cola
    {
        int[] arreglo;
        int inicio;
        int final;
        int contador;

        public Cola(int tam)
        {
            arreglo = new int[tam];
            inicio = 0;
            final = -1;
            contador = 0;
        }

        public void Encolar(int x)
        {
            if (final == arreglo.Length - 1)
            {
                final = -1;
            }
            arreglo[++final] = x;
            contador++;
        }

        public int Desencolar()
        {
            if (inicio > final)
            {
                throw new InvalidOperationException("Cola vacía");
            }
            int x = arreglo[inicio++];
            contador--;
            return x;
        }

        public int Frente()
        {
            if (inicio > final)
            {
                throw new InvalidOperationException("Cola vacía");
            }
            return arreglo[inicio];
        }

        public int Tamaño()
        {
            return contador;
        }
    }
}
