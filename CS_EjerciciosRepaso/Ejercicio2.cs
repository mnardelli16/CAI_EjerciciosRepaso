using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio2
    {
        public void Ejercicio_2()
        {
            string StrRegistro;
            bool flag;
            int Registro = 0;

            do
            {
                Console.WriteLine("Por favor ingrese Numero de Registro: ");
                StrRegistro = Console.ReadLine();

                flag = new Funciones().ValidarNumero(StrRegistro, ref Registro, 1);

            } while (flag == false);

            string N = Registro.ToString().Substring(Registro.ToString().Length - 3, 3);

            int NuevoReg;

            if (N.Substring(0, 1) == "0")
            {
                NuevoReg = Convert.ToInt32(N) + 100;
                Console.WriteLine("El nuevo numero de registro es: {0}", NuevoReg);
            }

            else
            {
                NuevoReg = Convert.ToInt32(N);
            }

            for (int i = 1; i <= NuevoReg; i++)
            {
                bool bpr;
                int b = 0;

                for (int a = 1; a <= i; a++)
                {
                    if (i % a == 0)
                    {
                        b++;
                    }
                }

                if (b != 2)
                {
                    bpr = false;
                }
                else
                {
                    bpr = true;
                }

                if (bpr && i % 3 == 0)
                {
                    Console.WriteLine("{0} - Es primo y divisible por 3", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} - Es divisible por 3", i);
                }
                else if (bpr)
                {
                    Console.WriteLine("{0} - Es primo", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
