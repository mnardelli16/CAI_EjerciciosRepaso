using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio18
    {
        public void Ejercicio_18()
        {
            int dec = 0;
            string _num;

            bool flag2;
            do
            {
                Console.Write("Ingrese un numero: ");
                _num = Console.ReadLine();
                flag2 = new Funciones().ValidarNumero(_num, ref dec, 2);
            } while (flag2 == false);
            {
                Console.WriteLine("El numero decimal es: {0}\nBinario: {1}\nOctal: {2}\nHexadecimal: {3}", dec, Convert.ToString(dec, 2), Convert.ToString(dec, 8), Convert.ToString(dec, 16));
            }
        }
    }
}
