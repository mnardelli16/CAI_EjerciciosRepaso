using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio20
    {
        public void Ejercicio_20()
        {
            int num = 0;
            string _num;

            bool flag2;
            do
            {
                Console.Write("Ingrese un numero: ");
                _num = Console.ReadLine();
                flag2 = new Funciones().ValidarNumero(_num, ref num, 2);
            } while (flag2 == false);

            int primos = 0;
            bool esPrimo;
            double factorial = 1;

            for(int i = 1; i <= num; i++)
            {
                factorial *=  i;

                int aux = 2;
                esPrimo = true;

                while(aux < i)
                {
                    if (i % aux == 0)
                        esPrimo = false;
                    aux++;
                }
                if(esPrimo && i > 1)
                {
                    primos++;
                }

            }

            Console.WriteLine("Hasta el numero {0} hay {1} numeros primos y el factorial es {2}", num, primos, factorial);

        }
    }
}
