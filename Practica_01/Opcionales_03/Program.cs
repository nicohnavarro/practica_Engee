using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcionales_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Construimos la Matriz
            int[,] miMatriz = new int[12, 14];
            int numeroPrimo = 2;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        miMatriz[i, j] = numeroPrimo;
                        numeroPrimo++;
                    }
                    else
                    {
                        while (true)
                        {
                            int divisores = 0;
                            for (int k = 1; k < numeroPrimo + 1; k++)
                            {
                                if (numeroPrimo % k == 0)
                                {
                                    divisores++;
                                }
                            }
                            if (divisores == 2)
                            {
                                miMatriz[i, j] = numeroPrimo;
                                numeroPrimo++;
                                break;
                            }
                            else if (divisores != 2)
                            {
                                numeroPrimo++;
                            }
                        }
                    }
                }
            }
            /*
            for(int i = 0; i < 12; i++)
            {
                for(int j=0; j < 14; j++)
                {
                    Console.Write("{0} ",miMatriz[i,j]);
                }
                Console.WriteLine("\n");
            }
            */
            #endregion

            #region User
            int filas;
            int columnas;

            do
            {
                Console.WriteLine("Ingrese la cantidad de filas: ");
                if (int.TryParse(Console.ReadLine(), out filas))
                {
                    if (filas < 15 && filas > 0)
                    {
                        Console.WriteLine("Ingrese la cantidad de columnas: ");
                        if (int.TryParse(Console.ReadLine(), out columnas))
                        {
                            if (columnas < 13 && columnas > 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Error de columnas\n");
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error de filas\n");
                    }
                }
            } while (true);
            #endregion

            #region Nueva Matriz
            int[,] miNuevaMatriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    miNuevaMatriz[i, j] = miMatriz[i, j];
                }
            }
            /*
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write("{0} ",miNuevaMatriz[i, j]);
                }
                Console.WriteLine("\n");
            }
            */
            #endregion

            #region Salida
            int elementos = filas * columnas;
            int x = 0; //Para filas
            int y = 0; //Para columnas
            int n = 0; //Contador elementos
            int flag = 0; //Para diferenciar recorrido

            while (n < elementos)
            {
                switch (flag)
                {
                    case 0: //Recorrido de izquierda a derecha
                        for (int m = x ; m < columnas - y; m++)
                        {
                            Console.Write("{0}, ", miNuevaMatriz[x, m]);
                            n++;
                        }
                        flag++;
                        break;

                    case 1: //Recorrido de arriba a abajo
                        for (int m = x + 1; m < filas - x; m++)
                        {
                            Console.Write("{0}, ", miNuevaMatriz[m, columnas - 1 - y]);
                            n++;
                        }
                        flag++;
                        break;

                    case 2: //Recorrido de derecha a izquierda
                        for (int m = columnas - 2 - y; m >= y; m--)
                        {
                            Console.Write("{0}, ", miNuevaMatriz[filas - 1 - x, m]);
                            n++;
                        }
                        flag++;
                        break;

                    case 3: //Recorrido de abajo a arriba
                        for (int m = filas - 2 - x; m >= x + 1; m--)
                        {
                            Console.Write("{0}, ",miNuevaMatriz[m,y]);
                            n++;
                        }
                        flag = 0;
                        x++; //Se aumentan las filas y columnas
                        y++; //Para un subnivel en el espiral
                        break;
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
