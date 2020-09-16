using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio16
    {
        public void Ejercicio_16()
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

            Console.WriteLine("Numero ingresado: {0} - Tiene {1} digitos",numero, _num.Length);

        }
    }
}
