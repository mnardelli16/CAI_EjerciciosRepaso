using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            string _strnum;
            int _num = 0;
            bool flag;
            bool ok;
            string opcion;
            do
            {

                do
                {
                    Console.Write("Por favor seleccione un ejercicio: ");
                    _strnum = Console.ReadLine();

                    flag = new Funciones().ValidarIngresoEjercicio(_strnum, ref _num);

                } while (flag == false);


                switch (_num)
                {
                    case 1:
                        {
                            Ejercicio1 E = new Ejercicio1();
                            E.Ejercicio_1();
                            break;
                        }
                    case 2:
                        {
                            Ejercicio2 E = new Ejercicio2();
                            E.Ejercicio_2();
                            break;
                        }
                    case 3:
                        {
                            Ejercicio3 E = new Ejercicio3();
                            E.Ejercicio_3();
                            break;
                        }
                    case 4:
                        {
                            Ejercicio4 E = new Ejercicio4();
                            E.Ejercicio_4();
                            break;
                        }
                    case 5:
                        {
                            Ejercicio5 E = new Ejercicio5();
                            E.Ejercicio_5();
                            break;
                        }
                    case 6:
                        {
                            Ejercicio6 E = new Ejercicio6();
                            E.Ejercicio_6();
                            break;
                        }
                    case 7:
                        {
                            Ejercicio7 E = new Ejercicio7();
                            E.Ejercicio_7();
                            break;
                        }
                    case 8:
                        {
                            Ejercicio8 E = new Ejercicio8();
                            E.Ejercicio_8();
                            break;
                        }
                    case 9:
                        {
                            Ejercicio9 E = new Ejercicio9();
                            E.Ejercicio_9();
                            break;
                        }
                    case 10:
                        {
                            Ejercicio10 E = new Ejercicio10();
                            E.Ejercicio_10();
                            break;
                        }
                    case 11:
                        {
                            Ejercicio11 E = new Ejercicio11();
                            E.Ejercicio_11();
                            break;
                        }
                    case 12:
                        {
                            Ejercicio12 E = new Ejercicio12();
                            E.Ejercicio_12();
                            break;
                        }
                    case 13:
                        {
                            Ejercicio13 E = new Ejercicio13();
                            E.Ejercicio_13();
                            break;
                        }
                    case 14:
                        {
                            Ejercicio14 E = new Ejercicio14();
                            E.Ejercicio_14();
                            break;
                        }
                    case 15:
                        {
                            Ejercicio15 E = new Ejercicio15();
                            E.Ejercicio_15();
                            break;
                        }
                    case 16:
                        {
                            Ejercicio16 E = new Ejercicio16();
                            E.Ejercicio_16();
                            break;
                        }
                    case 17:
                        {
                            Ejercicio17 E = new Ejercicio17();
                            E.Ejercicio_17();
                            break;
                        }
                    case 18:
                        {
                            Ejercicio18 E = new Ejercicio18();
                            E.Ejercicio_18();
                            break;
                        }
                    case 19:
                        {
                            Ejercicio19 E = new Ejercicio19();
                            E.Ejercicio_19();
                            break;
                        }
                    case 20:
                        {
                            Ejercicio20 E = new Ejercicio20();
                            E.Ejercicio_20();
                            break;
                        }
                }

                do
                {
                    Console.WriteLine("Desea probar otro ejercicio S/N : ");
                    opcion = Console.ReadLine();
                    ok = new Funciones().ValidarSalida(opcion);
                } while (ok == false);

            } while (opcion == "S");

            Console.WriteLine("HASTA LUEGO! ");

            Console.ReadKey();
         
        }
    }
}
