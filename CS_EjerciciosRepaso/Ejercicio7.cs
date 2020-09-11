using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio7
    {
        public void Ejercicio_7()
        {
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                bool flag;
                do
                {
                    string num;
                    Console.Write("Ingrese el numero {0}: ", i + 1);
                    num = Console.ReadLine();
                    flag = new Funciones().ValidarNumero(num, ref numeros[i], 2);
                } while (flag == false);
            }

            Array.Sort(numeros);
            Console.WriteLine("El numero menor es: " + numeros[0]);
            Console.WriteLine("El numero intermedio es: " + numeros[2]);
            Console.WriteLine("El numero mayor es: " + numeros[4]);
        }

    }
}
