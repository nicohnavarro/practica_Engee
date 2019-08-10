using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcionales_01
{
    class Problema_01
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ---------------Ejercicios practicos Opcionales 1 ---------------");
            int horas;
            int minutos;
            bool flag=true;
            Reloj miReloj;
            while (flag)
            {
                Console.WriteLine("Ingrese horas: ");
                if (int.TryParse(Console.ReadLine(), out horas))
                {
                    Console.WriteLine("Ingrese minutos: ");
                    if (int.TryParse(Console.ReadLine(), out minutos))
                    {
                        try
                        {
                            miReloj = new Reloj(horas, minutos);
                            flag = false;
                            Console.WriteLine("La hora ingresada es {0}:{1}", horas, minutos);
                            Console.WriteLine("Presione cualquier tecla para calcular los angulos");
                            Console.ReadKey();
                            Console.WriteLine("Angulo de la aguja de las horas: {0}°", miReloj.Calcular_Angulo_Horas());
                            Console.WriteLine("Angulo de la aguja de los minutos: {0}°", miReloj.Calcular_Angulo_Minutos());
                        }
                        catch (RelojException e)
                        {
                            Console.Clear();
                            Console.WriteLine(e.Message);
                        }

                    }
                } 
            }
            
            Console.ReadKey();
        }
    }
}
