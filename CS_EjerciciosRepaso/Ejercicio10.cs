using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio10
    {
        public void Ejercicio_10()
        {
            string _ingreso;
            char _salida = 'c';
            bool flag;

            do
            {
                Console.WriteLine("Por favor ingrese un caracter: ");
                _ingreso =  Console.ReadLine();
                flag = new Funciones().ValidarChar(_ingreso, ref _salida);

            } while (flag == false);

            if("aeiou".Contains(_salida))
            {
                Console.WriteLine("El caracter {0} es una vocal",_salida);
            }
            else if("0123456789".Contains(_salida))
            {
                Console.WriteLine("El caracter {0} es un numero", _salida);
            }
            else if ("bcdfghjklmnpqrstvwxyz".Contains(_salida))
            {
                Console.WriteLine("El caracter {0} es una consonante", _salida);
            }
            else
            {
                Console.WriteLine("El caracter {0} es una consonante, vocal ni numero", _salida);
            }


        }
    }
}
