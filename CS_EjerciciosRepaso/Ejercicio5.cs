using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio5
    {

        public void Ejercicio_5()
        {
            string _strnumero;
            bool _flag;
            int _numero = 0;

            do
            {
                Console.WriteLine("Por favor ingrese un Numero: ");
                _strnumero = Console.ReadLine();

                _flag = new Funciones().ValidarNumero(_strnumero, ref _numero, 2);

            } while (_flag == false);

            int _largo = _numero.ToString().Length;
            int _contador = _largo;
            string _numinvertido = "";

            for (int i = 0; i < _largo; i++)
            {
                _numinvertido += _numero.ToString().Substring(_contador - 1, 1);
                _contador--;
            }

            Console.WriteLine("El numero invertido es: " + _numinvertido);
        }

    }
}
