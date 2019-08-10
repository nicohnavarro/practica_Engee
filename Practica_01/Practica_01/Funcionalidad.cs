using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    public static class Funcionalidad
    {
        /// <summary>
        /// Metodo para realizar los calculos necesario en base al criterio de paridad
        /// </summary>
        /// <param name="numero">Numero a iterar</param>
        /// <returns>lista con los terminos que posee el numero</returns>
        public static List<int> Probar_Secuencia(int numero)
        {
            List<int> miArray = new List<int>();
            miArray.Add(numero);
            int paridad;
            while (numero > 1)
            {
                paridad = numero % 2;
                switch (paridad)
                {
                    case 0:
                        {
                            numero = numero / 2;
                            miArray.Add(numero);
                            break;
                        }
                    case 1:
                        {
                            numero = (numero * 3) + 1;
                            miArray.Add(numero);
                            break;
                        }
                }
            }
            return miArray;
        }

        /// <summary>
        /// Metodo para comparar entre dos listas de numero deacuerdo a su
        /// cantidad de terminos
        /// </summary>
        /// <param name="lista1">lista uno</param>
        /// <param name="lista2">lista dos</param>
        /// <returns>(1) si lista1 es mayor a lista2 - (-1) si lista2 es mayor a lista1 (0) si son igules</returns>
        public static int Devolver_Mayor(List<int> lista1, List<int> lista2)
        {
            int retorno = 0;

            if (lista1.Count < lista2.Count)
                retorno=1;
            else if(lista1.Count > lista2.Count)
                retorno=-1;

            return retorno;
        }

        /// <summary>
        /// Metodo que desde el numero pasado por parametro hasta 1 
        /// agrega a una lista de numeros, los numeros con sus respectivos terminos
        /// </summary>
        /// <param name="numero">cantidad de numeros deseada</param>
        /// <returns>lista de numeros con terminos</returns>
        public static List<List<int>> Devolver_Listas(int numero)
        {
            List<List<int>> miListaArray = new List<List<int>>();
            List<int> lista = new List<int>();
            while (numero > 1)
            {
                lista = Funcionalidad.Probar_Secuencia(numero);
                numero--;
                miListaArray.Add(lista);
            }
            return miListaArray;

        }

        /// <summary>
        /// Devuelve el numero con mayor cantidad de terminos
        /// </summary>
        /// <param name="listas">listas de numeros</param>
        /// <returns>lista de numero con mayor cantidad de terminos</returns>
        public static List<int> Devolver_Ganador(List<List<int>> listas)
        {
            listas.Sort(Funcionalidad.Devolver_Mayor);
            return listas[0];
        }
    }
}
