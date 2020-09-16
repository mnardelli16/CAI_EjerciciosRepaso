using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio19
    {
        public void Ejercicio_19()
        {
            int num = 0;
            string _num;

            bool flag2;
            do
            {
                Console.Write("Ingrese la cantidad de palabras a ingresar: ");
                _num = Console.ReadLine();
                flag2 = new Funciones().ValidarNumero(_num, ref num, 2);
            } while (flag2 == false);

            string palabra;
            string[] lista = new string[num];

            for(int i = 0; i < num;i++)
            {
                do
                {
                    Console.Write("Ingrese la palabra numero {0}: ",i+1);
                    palabra = Console.ReadLine();
                    flag2 = new Funciones().ValidarString(palabra);
                } while (flag2 == false);

                lista[i] = palabra;
            }

            for (int a = 0; a < lista.Length; a++)
            {
                Console.WriteLine("Palabra: {0} -  Longitud: {1}", lista[a],lista[a].Length);
            }

        }
    }
}
