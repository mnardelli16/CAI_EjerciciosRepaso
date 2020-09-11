using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio9
    {
        public void Ejercicio_9()
        {
            string _nombre;
            bool flag;
            do
            {
                Console.Write("Ingrese su nombre: ");
                _nombre = Console.ReadLine();
                flag = new Funciones().ValidarString(_nombre);
            } while (flag == false);

            if (_nombre == "Maxi")
            {
                Console.WriteLine("¡Hola, {0}!", _nombre);
            }
            else
            {
                Console.WriteLine("No te conozco");
            }


        }
    }
}
