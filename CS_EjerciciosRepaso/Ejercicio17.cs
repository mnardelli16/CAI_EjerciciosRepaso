using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio17
    {
        public void Ejercicio_17()
        {
            string[,] Empleados = new string[5, 2];
            int sueldomax = 0;
            int sueldo = 0;
            int pos = 0;
            for (int i = 0; i < Empleados.GetLength(0); i++)
            {
                string nombre;
                bool flag;
                do
                {
                    Console.Write("Ingrese el nombre del empleado {0}: ", i + 1);
                    nombre = Console.ReadLine();
                    flag = new Funciones().ValidarString(nombre);
                } while (flag == false);
                Empleados[i, 0] = nombre;

                string _num;

                bool flag2;
                do
                {
                    Console.Write("Ingrese el sueldo del empleado {0}: ", i + 1);
                    _num = Console.ReadLine();
                    flag2 = new Funciones().ValidarNumero(_num, ref sueldo, 2);
                } while (flag2 == false);

                Empleados[i, 1] = sueldo.ToString();

                if(Convert.ToInt32(Empleados[i, 1]) > sueldomax)
                {
                    sueldomax = Convert.ToInt32(Empleados[i, 1]);
                    pos = i;
                }
            }


            Console.WriteLine("El sueldo mayor es {0} del empleado {1}",sueldomax.ToString(), Empleados[pos,0]);
        }
    }
}
