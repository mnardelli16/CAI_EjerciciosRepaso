using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EjerciciosRepaso
{
    class Ejercicio12
    {
        public void Ejercicio_12()
        {
            int[] vDiasMes = new int[12] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            DateTime vFechaOrigen;
            DateTime vFechaDestino;
            int vAnio;
            int vMes;
            int vDia;
            int vIncremento;

            string _strfecha1;
            string _strfecha2;
            DateTime[] fechas = new DateTime[2];
            bool flag = false;
            bool flag2 = false;


            do
            {
                Console.Write("Por favor ingrese la primer fecha: ");
                _strfecha1 = Console.ReadLine();
                flag = new Funciones().ValidarFecha(_strfecha1, ref fechas[0]);
            } while (flag == false);

            do
            {
                Console.Write("Por favor ingrese la segunda fecha: ");
                _strfecha2 = Console.ReadLine();
                flag2 = new Funciones().ValidarFecha(_strfecha2, ref fechas[1]);
            } while (flag2 == false);

            //Determinamos cual es la fecha menor
            if (fechas[0] > fechas[1])
            {
                vFechaOrigen = fechas[1];
                vFechaDestino = fechas[0];
            }
            else
            {
                vFechaOrigen = fechas[0];
                vFechaDestino = fechas[1];
            }

            // Calculamos los dias
            vIncremento = 0;

            if (vFechaOrigen.Day > vFechaDestino.Day)
            {
                vIncremento = vDiasMes[vFechaOrigen.Month - 1];

            }
            if (vIncremento == -1)
            {
                if (DateTime.IsLeapYear(vFechaOrigen.Year))
                {
                    // Para los años bisiestos
                    vIncremento = 29;
                }
                else
                {
                    vIncremento = 28;
                }
            }
            if (vIncremento != 0)
            {
                vDia = (vFechaDestino.Day + vIncremento) - vFechaOrigen.Day;
                vIncremento = 1;
            }
            else
            {
                vDia = vFechaDestino.Day - vFechaOrigen.Day;
            }

            //Calculamos los meses
            if ((vFechaOrigen.Month + vIncremento) > vFechaDestino.Month)
            {
                vMes = (vFechaDestino.Month + 12) - (vFechaOrigen.Month + vIncremento);
                vIncremento = 1;
            }
            else
            {
                vMes = (vFechaDestino.Month) - (vFechaOrigen.Month + vIncremento);
                vIncremento = 0;
            }

            //Calculamos los años
            vAnio = vFechaDestino.Year - (vFechaOrigen.Year + vIncremento);
            
            Console.WriteLine("La Diferencia es de {0} años, {1} meses y {2} días", vAnio, vMes, vDia);
        }
    }
}
