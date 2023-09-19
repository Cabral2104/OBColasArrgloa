using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBColasArrgloa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola(5);

            cola.Encolar(1);
            cola.Encolar(2);
            cola.Encolar(3);

            Console.WriteLine(cola.Tamaño()); // 3
            Console.WriteLine(cola.Desencolar()); // 1
            Console.WriteLine(cola.Frente()); // 2

            cola.Encolar(4);
            Console.WriteLine(cola.Tamaño()); // 3
            Console.ReadKey();
        }
    }
}
