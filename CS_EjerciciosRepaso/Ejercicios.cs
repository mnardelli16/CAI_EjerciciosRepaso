using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicios
    {
        public void Ejercicio1()
        {
            string StrRegistro;
            bool flag = false;
            int Registro = 0;

            do
            {
                Console.WriteLine("Por favor ingrese Numero de Registro");
                StrRegistro = Console.ReadLine();

                flag = ValidarNumero(StrRegistro, ref Registro);

            } while (flag == false);

            string NuevoRegSTR = Registro.ToString().Substring(3, 3);
            int NuevoReg = 0;

            if (NuevoRegSTR.Substring(0, 1) == "0")
            {
                int R = Convert.ToInt32(NuevoRegSTR);
                NuevoReg = R + 100;
                Console.WriteLine("El nuevo numero de registro es: {0}", NuevoReg);
            }


            for( int i = 1; i <= NuevoReg; i++ )
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0} - FooBar", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} - Foo", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0} - Bar", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private bool ValidarNumero(string NroRegistro, ref int Registro)
        {
            bool flag = false;

            if(!Int32.TryParse(NroRegistro, out Registro))
            {
                Console.WriteLine("Debe ingresar un numero");
            }
            else if (Registro <= 0)
            {
                Console.WriteLine("Debe ingresar un numero positivo");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

    }
}
