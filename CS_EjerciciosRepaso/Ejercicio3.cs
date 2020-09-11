using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio3
    {
        public void Ejercicio_3()
        {
            string _palabra;
            bool flag;
            do
            {
                Console.Write("Ingrese la palabra: ");
                _palabra = Console.ReadLine();
                flag = new Funciones().ValidarString(_palabra);
            } while (flag == false);

            int largo = _palabra.Length;
            int contador = largo;
            string palabrainvertida = "";

            for (int i = 0; i < largo; i++)
            {
                palabrainvertida += _palabra.Substring(contador - 1, 1);
                contador--;
            }

            if (string.Compare(_palabra, palabrainvertida) == 0)
            {
                Console.WriteLine("La palabra " + _palabra + " es PALINDROMO");
            }
            else
            {
                Console.WriteLine("La palabra " + _palabra + " NO es PALINDROMO");
            }
        }

    }
}
