using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio8
    {
        public void Ejercicio_8()
        {
            string _strfecha;
            DateTime _fecha = new DateTime();
            bool flag;

            do
            {
                Console.Write("Por favor ingrese una fecha: ");
                _strfecha = Console.ReadLine();
                flag = new Funciones().ValidarFecha(_strfecha, ref _fecha);
            } while (flag == false);

            int dif = (DateTime.Now.Date - _fecha.Date).Days;

            Console.WriteLine("La diferencia de dias es: {0}", dif);

        }
    }
}
