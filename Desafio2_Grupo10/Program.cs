using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_Grupo10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            int cant = 0;
            int n = 0;
            string valor = "";

            //Variables Promedio

            float suma = 0.0f;
            float prom = 0.0f;

            float min = 10.0f;//nota minima
            float max = 0.0f; //nota maxima

            Console.WriteLine("Ingrese la cantidad de alumnos: ");
            valor = Console.ReadLine();
            cant = int.Parse(valor);

            //Array
            float[] nota = new float[cant];

            for (n = 0; n < cant; n++)
            {
                Console.Write("Ingrese la nota: ");
                valor = Console.ReadLine();
                nota[n] = Convert.ToSingle(valor);
            }

            //Para sacar el promedio
            for (n = 0; n < cant; n++)
            {
                suma += nota[n];
            }

            prom = suma / cant;

            //Nota Minima
            for (n = 0; n < cant; n++)
            {
                if (nota[n] < min)
                    min = nota[n];
            }

            //Nota Maxima
            for (n = 0; n < cant; n++)
            {
                if (nota[n] > max)
                    max = nota[n];
            }

            Console.WriteLine("El promedio es {0} ", prom);
            Console.WriteLine("La nota minima es {0} ", min);
            Console.WriteLine("La nota maxima es {0} ", max);

            Console.ReadKey();
        }
    }
}
