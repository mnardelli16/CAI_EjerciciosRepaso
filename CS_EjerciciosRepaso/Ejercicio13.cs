using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio13
    {
        public void Ejercicio_13()
        {
            string _num;
            int numero = 0;
            bool flag;
            do
            {
                Console.Write("Ingrese un numero: ");
                _num = Console.ReadLine();
                flag = new Funciones().ValidarNumero(_num, ref numero, 2);
            } while (flag == false);

            double acumulador = 1;

            for(int i = 2; i <= numero; i++)
            {
                acumulador = acumulador * i;
            }

            Console.WriteLine("El factorial del numero {0} es {1}", numero, acumulador);

        }
    }
}
