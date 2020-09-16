using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio14
    {
        public void Ejercicio_14()
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

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
                }
            }
            catch(Exception e)
            {
               Console.WriteLine(e.Message);
            }

        }
    }
}
