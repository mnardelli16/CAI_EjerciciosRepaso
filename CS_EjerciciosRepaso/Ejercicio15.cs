using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio15
    {
        public void Ejercicio_15()
        {
            string _clave;
            const string _user = "mnardelli";
            int contador = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Ingrese la password - Intento {0}: ", i);
                _clave = Console.ReadLine();

                if (_user == _clave)
                {
                    Console.WriteLine("Bienvenido, {0}",_user);
                    break;
                }
                else
                {
                    Console.WriteLine("Acceso denegado. La contraseña no es correcta");
                    contador++;
                }
            }

            if(contador == 3)
            {
                Console.WriteLine("Clave Bloqueada");
            }

        }
    }
}
