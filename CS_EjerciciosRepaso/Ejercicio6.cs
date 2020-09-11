using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio6
    {
        public void Ejercicio_6()
        {
            string _num1;
            int _numero1 = 0;
            string _num2;
            int _numero2 = 0;
            bool flag;
            do
            {
                Console.Write("Ingrese el primer numero: ");
                _num1 = Console.ReadLine();
                flag = new Funciones().ValidarNumero(_num1, ref _numero1, 2);
            } while (flag == false);
            do
            {
                Console.Write("Ingrese el segundo numero: ");
                _num2 = Console.ReadLine();
                flag = new Funciones().ValidarNumero(_num2, ref _numero2, 2);
            } while (flag == false);

            int resultado = (_numero1 + _numero2) * (_numero1 - _numero2);

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
