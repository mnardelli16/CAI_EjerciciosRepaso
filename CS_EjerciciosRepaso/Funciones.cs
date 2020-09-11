using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Funciones
    {
        public bool ValidarNumero(string NroRegistro, ref int Registro, int opcion)
        {
            bool flag = false;
            if (!Int32.TryParse(NroRegistro, out Registro))
            {
                Console.WriteLine("Debe ingresar un numero");

                if (opcion == 1) // valido registro
                {
                    if (Registro <= 999)
                    {
                        Console.WriteLine("Debe ingresar un numero positivo y mayor a 1000");
                    }
                }
                else if (opcion == 2) //valido numero comun
                {
                    if (Registro <= 0)
                    {
                        Console.WriteLine("Debe ingresar un numero positivo");
                    }
                }
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarString(string palabra)
        {
            bool val = false;
            //int salida;
            if (string.IsNullOrWhiteSpace(palabra))
            {
                Console.WriteLine("De ingresar una palabra");
            }
            else if (Int32.TryParse(palabra, out _))
            {
                Console.WriteLine("No debe ingresar valores numericos");
            }
            else
            {
                val = true;
            }
            return val;
        }

        public string SortString(string input)
        {
            char[] caracteres = input.ToArray();
            Array.Sort(caracteres);
            return new string(caracteres);
        }

        public bool ValidarIngresoEjercicio(string num, ref int salida)
        {
            bool flag = false;
            if (!Int32.TryParse(num, out salida))
            {
                Console.WriteLine("Debe ingresar un numero");
            }
            else if (salida < 1 || salida > 20)
            {
                Console.WriteLine("Debe ingresar un numero entre 1 y 20");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarFecha(string strfecha, ref DateTime salida)
        {
            bool flag = false;
            if(!DateTime.TryParse(strfecha, out salida))
            {
                Console.WriteLine("No es un formato de fecha valido");
            }
            else if (salida == DateTime.Now)
            {
                Console.WriteLine("La fecha debe ser menor a la de hoy");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public bool ValidarChar(string a, ref char salida)
        {
            bool flag = false;
            //Regex rgx = new Regex("^[A - Za - z] + $");
            if (!char.TryParse(a, out salida))
            {
              Console.WriteLine("Debe ingresar un caracter solo");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public bool ValidarSalida(string a)
        {
            bool flag = false;
            if(string.IsNullOrWhiteSpace(a))
            {
                Console.WriteLine("No debe dejar espacios en blanco");
            }
            else if (a == "S")
            {
                flag = true;
            }
            else if (a == "N")
            {
                flag = true;
            }
            else
            {
                Console.WriteLine("No son opciones validas");
            }
            return flag;
        }
    }
}
