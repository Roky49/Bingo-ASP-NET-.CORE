using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bingo.Repositories
{
    public class RepositoryBingo:IrepositoryBingo 
    {
        #region
        //int n = 90;//numero aleatorios
        //int k = n; //auxiliar
        //Random ale = new Random();
        //int res;
        //int[] numeros = new int[n];
        //int[] resultado = new int[n];

        ////relleno el array
        //for (int i = 0; i < n; i++)
        //{
        //    numeros[i] = i + 1;
        //}

        //for (int i = 0; i < n; i++)
        //{
        //    res = ale.Next(k);
        //    resultado[i] = numeros[res];
        //    numeros[res] = numeros[k - 1];
        //    k--;
        //}
        #endregion
     

        public List<int> GenerarNumeros()
        {
            List<int> numeros = new List<int>();
            for (int i = 1; i <= 90; i++)
            {
                numeros.Add(i);
            }

            return numeros;
        }
       
        public List<int> NumerosAleatorios()
        {
            Random ale = new Random();

            HashSet<int> ListaAleatoriosCompleta = new HashSet<int>();

            do
            {
                int a = ale.Next(1, 91);
                ListaAleatoriosCompleta.Add(a);

            } while (ListaAleatoriosCompleta.Count() < 90);


            List<int> aleatoriosDesordenados = new List<int>();

            foreach (int i in ListaAleatoriosCompleta)
            {
                aleatoriosDesordenados.Add(i);
            }

            return aleatoriosDesordenados;
        }

        public List<int> GenerarCartones()
        {

            Random ale = new Random();

            HashSet<int> ListaAleatoriosCompleta = new HashSet<int>();

            do
            {
                int a = ale.Next(1, 91);
                ListaAleatoriosCompleta.Add(a);

            } while (ListaAleatoriosCompleta.Count() < 90);


            List<int> aleatoriosDesordenados = new List<int>();

            foreach (int i in ListaAleatoriosCompleta)
            {
                aleatoriosDesordenados.Add(i);
            }



            return aleatoriosDesordenados;

        }

        public int[,] validarCarton(List<int> Ordenados)
        {


            int[,] carton = new int[3, 9];
            int cont = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0, cont8 = 0, cont9 = 0;
            foreach (int i in Ordenados)
            {
                if (i <= 10 && i >= 0)
                {
                    if (cont == 2)
                    {
                        carton[2, 0] = i;
                        cont++;
                    }
                    if (cont == 1)
                    {
                        carton[1, 0] = i;
                        cont++;
                    }

                    if (cont == 0)
                    {
                        carton[0, 0] = i;
                        cont++;
                    }

                }
                if (i <= 20 && i >= 11)
                {
                    if (cont2 == 2)
                    {
                        carton[2, 1] = i;
                        cont2++;
                    }

                    if (cont2 == 1)
                    {
                        carton[1, 1] = i;
                        cont2++;
                    }

                    if (cont2 == 0)
                    {
                        carton[0, 1] = i;
                        cont2++;
                    }

                }
                if (i <= 30 && i >= 21)
                {
                    if (cont3 == 2)
                    {
                        carton[2, 2] = i;
                        cont3++;
                    }

                    if (cont3 == 1)
                    {
                        carton[1, 2] = i;
                        cont3++;
                    }

                    if (cont3 == 0)
                    {
                        carton[0, 2] = i;
                        cont3++;
                    }

                }
                if (i <= 40 && i >= 31)
                {
                    if (cont4 == 2)
                    {
                        carton[2, 3] = i;
                        cont4++;
                    }
                    if (cont4 == 1)
                    {
                        carton[1, 3] = i;
                        cont4++;
                    }

                    if (cont4 == 0)
                    {

                        carton[0, 3] = i;
                        cont4++;
                    }
                }
                if (i <= 50 && i >= 41)
                {
                    if (cont5 == 2)
                    {
                        carton[2, 4] = i;
                        cont5++;
                    }
                    if (cont5 == 1)
                    {
                        carton[1, 4] = i;
                        cont5++;
                    }

                    if (cont5 == 0)
                    {
                        carton[0, 4] = i;
                        cont5++;
                    }

                }
                if (i <= 60 && i >= 51)
                {
                    if (cont6 == 2)
                    {
                        carton[2, 5] = i;
                        cont6++;
                    }

                    if (cont6 == 1)
                    {
                        carton[1, 5] = i;
                        cont6++;
                    }

                    if (cont6 == 0)
                    {
                        carton[0, 5] = i;
                        cont6++;
                    }

                }
                if (i <= 70 && i >= 61)
                {
                    if (cont7 == 2)
                    {
                        carton[2, 6] = i;
                        cont7++;
                    }
                    if (cont7 == 1)
                    {
                        carton[1, 6] = i;
                        cont7++;
                    }

                    if (cont7 == 0)
                    {
                        carton[0, 6] = i;
                        cont7++;
                    }

                }
                if (i <= 80 && i >= 71)
                {
                    if (cont8 == 2)
                    {
                        carton[2, 7] = i;
                        cont8++;
                    }
                    if (cont8 == 1)
                    {
                        carton[1, 7] = i;
                        cont8++;
                    }

                    if (cont8 == 0)
                    {
                        carton[0, 7] = i;
                        cont8++;
                    }

                }
                if (i <= 90 && i >= 81)
                {
                    if (cont9 == 2)
                    {
                        carton[2, 8] = i;
                        cont9++;
                    }
                    if (cont9 == 1)
                    {
                        carton[1, 8] = i;
                        cont9++;
                    }

                    if (cont9 == 0)
                    {
                        carton[0, 8] = i;
                        cont9++;
                    }

                }

            }
            List<int> cartones = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cartones.Add(carton[i, j]);
                }
            }
            int[,] cartonOrdenado = new int[3, 9];
            cartones.Sort();
            cont = 0; cont2 = 0; cont3 = 0; cont4 = 0; cont5 = 0; cont6 = 0; cont7 = 0; cont8 = 0; cont9 = 0;
            foreach (int i in cartones)
            {
                if (i <= 10 && i >= 0)
                {
                    if (cont == 2)
                    {
                        cartonOrdenado[2, 0] = i;
                        cont++;
                    }
                    if (cont == 1)
                    {
                        cartonOrdenado[1, 0] = i;
                        cont++;
                    }

                    if (cont == 0)
                    {
                        cartonOrdenado[0, 0] = i;
                        cont++;
                    }

                }
                if (i <= 20 && i >= 11)
                {
                    if (cont2 == 2)
                    {
                        cartonOrdenado[2, 1] = i;
                        cont2++;
                    }

                    if (cont2 == 1)
                    {
                        cartonOrdenado[1, 1] = i;
                        cont2++;
                    }

                    if (cont2 == 0)
                    {
                        cartonOrdenado[0, 1] = i;
                        cont2++;
                    }

                }
                if (i <= 30 && i >= 21)
                {
                    if (cont3 == 2)
                    {
                        cartonOrdenado[2, 2] = i;
                        cont3++;
                    }

                    if (cont3 == 1)
                    {
                        cartonOrdenado[1, 2] = i;
                        cont3++;
                    }

                    if (cont3 == 0)
                    {
                        cartonOrdenado[0, 2] = i;
                        cont3++;
                    }

                }
                if (i <= 40 && i >= 31)
                {
                    if (cont4 == 2)
                    {
                        cartonOrdenado[2, 3] = i;
                        cont4++;
                    }
                    if (cont4 == 1)
                    {
                        cartonOrdenado[1, 3] = i;
                        cont4++;
                    }

                    if (cont4 == 0)
                    {

                        cartonOrdenado[0, 3] = i;
                        cont4++;
                    }
                }
                if (i <= 50 && i >= 41)
                {
                    if (cont5 == 2)
                    {
                        cartonOrdenado[2, 4] = i;
                        cont5++;
                    }
                    if (cont5 == 1)
                    {
                        cartonOrdenado[1, 4] = i;
                        cont5++;
                    }

                    if (cont5 == 0)
                    {
                        cartonOrdenado[0, 4] = i;
                        cont5++;
                    }

                }
                if (i <= 60 && i >= 51)
                {
                    if (cont6 == 2)
                    {
                        cartonOrdenado[2, 5] = i;
                        cont6++;
                    }

                    if (cont6 == 1)
                    {
                        cartonOrdenado[1, 5] = i;
                        cont6++;
                    }

                    if (cont6 == 0)
                    {
                        cartonOrdenado[0, 5] = i;
                        cont6++;
                    }

                }
                if (i <= 70 && i >= 61)
                {
                    if (cont7 == 2)
                    {
                        cartonOrdenado[2, 6] = i;
                        cont7++;
                    }
                    if (cont7 == 1)
                    {
                        cartonOrdenado[1, 6] = i;
                        cont7++;
                    }

                    if (cont7 == 0)
                    {
                        cartonOrdenado[0, 6] = i;
                        cont7++;
                    }

                }
                if (i <= 80 && i >= 71)
                {
                    if (cont8 == 2)
                    {
                        cartonOrdenado[2, 7] = i;
                        cont8++;
                    }
                    if (cont8 == 1)
                    {
                        cartonOrdenado[1, 7] = i;
                        cont8++;
                    }

                    if (cont8 == 0)
                    {
                        cartonOrdenado[0, 7] = i;
                        cont8++;
                    }

                }
                if (i <= 90 && i >= 81)
                {
                    if (cont9 == 2)
                    {
                        cartonOrdenado[2, 8] = i;
                        cont9++;
                    }
                    if (cont9 == 1)
                    {
                        cartonOrdenado[1, 8] = i;
                        cont9++;
                    }

                    if (cont9 == 0)
                    {
                        cartonOrdenado[0, 8] = i;
                        cont9++;
                    }

                }

            }


            return cartonOrdenado;
        }

        public int[,] taparCartones(int[,] carton)
        {



            Random ale = new Random();
            for (int i = 0; i < 3; i++)
            {
                HashSet<int> Aleatorios = new HashSet<int>();
                do
                {
                    int a = ale.Next(0, 9);
                    Aleatorios.Add(a);
                } while (Aleatorios.Count() < 4);

                foreach (int j in Aleatorios)
                {

                    carton[i, j] = 0;

                }

            }

            return carton;
        }



    }
}
