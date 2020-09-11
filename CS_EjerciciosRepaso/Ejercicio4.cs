using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio4
    {

        public void Ejercicio_4()
        {
            string _palabra1;
            string _palabra2;
            bool flag;
            do
            {
                Console.Write("Ingrese la primer palabra: ");
                _palabra1 = Console.ReadLine();
                flag = new Funciones().ValidarString(_palabra1);
            } while (flag == false);
            do
            {
                Console.Write("Ingrese la segunda palabra: ");
                _palabra2 = Console.ReadLine();
                flag = new Funciones().ValidarString(_palabra2);
            } while (flag == false);

            string ord1 = new Funciones().SortString(_palabra1);
            string ord2 = new Funciones().SortString(_palabra2);

            if (string.Compare(ord1, ord2) == 0)
            {
                Console.WriteLine("Las palabras son ANAGRAMAS");
            }
            else
            {
                Console.WriteLine("Las palabras NO son ANAGRAMAS");
            }

        }
    }
}
