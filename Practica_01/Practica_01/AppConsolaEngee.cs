using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    class AppConsolaEngee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica de Engee ...\n");
            List<int> listaNumero; //= Funcionalidad.Probar_Secuencia(13);
            //foreach (int numero in listaNumero)
            //{
            //    Console.Write(numero+" ");
            //}
            Console.ReadKey();

            Console.WriteLine("Prueba del 1000000 a 1 devolver el mayor.\n");
            List<List<int>> miListas;
            miListas = Funcionalidad.Devolver_Listas(1000000);
            listaNumero = Funcionalidad.Devolver_Ganador(miListas);
            Console.WriteLine("El numero con mayor cantidad de terminos es {0}", listaNumero[0]);
            Console.WriteLine("Con una cantidad de terminos de {0}",listaNumero.Count);

            Console.ReadKey();
        }
    }
}
