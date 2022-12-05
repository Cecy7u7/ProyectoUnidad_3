using System;
namespace Proyecto
{
    class Program
    {
        private static string[] OpcionesMenu = new string[]
        {
            "ORDENAR DE MENOR A MAYOR",
            "AVERIGUE SI UNA LISTA DE NÚMEROS ESTÁ ORDENADA DE MANERA ESTRICTAMENTE CRECIENTE",
            "AVERIGUA SI UNA LISTA DE NÚMEROS ESTÁ ORDENADA DE MENOR A MAYOR",
            "INTERCAMBIE LOS ELEMENTOS DE UN VECTOR",
            "AVERIGUE SI UNA LISTA TIENE NÚMEROS REPETIDOS",
            "DE UNA LISTA DE NÚMEROS AVERIGUE SI EL NÚMERO t ESTÁ EN LA LISTA",
            "HALLE EL PROMEDIO DE LOS ELEMENTOS DE UN VECTOR",
        };

        private static int x;
        private static int y;


        static void Main(string[] args)
        {
            bool Loop = true;
            int counter = 0;
            ConsoleKeyInfo Tecla;

            Console.CursorVisible = false;

            Console.WriteLine("--------BIENVENIDO SELECCIONA UNA OPCIÓN--------" + System.Environment.NewLine);
            x = Console.CursorLeft;
            y = Console.CursorTop;

            string Resultado = Menu(OpcionesMenu, counter);


            while (Loop)
            {
                while ((Tecla=Console.ReadKey(true)).Key != ConsoleKey.Enter)
                {
                    switch (Tecla.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (counter == OpcionesMenu.Length - 1) continue;
                            counter++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (counter == 0) continue;
                            counter--;
                            break;
                        default:
                            break;
                    }

                    Console.CursorLeft = x;
                    Console.CursorTop = y;

                    Resultado=Menu(OpcionesMenu, counter);

                }


                switch (counter)
                {
                    case 0://MENOR A MAYOR (o)
                        Loop = true;
                        Console.Clear();

                        int ac = 0, c = 0, r = 0, aux = 0;

                        Console.WriteLine("INGRESE LA SERIE DE NÚMEROS: ");
                        int n = int.Parse(Console.ReadLine());
                        while (c <= 9)
                        {
                            aux = n;
                            while (aux > 0)
                            {
                                r = aux % 10;
                                if (r == c)
                                {
                                    ac = (ac * 10) + r;
                                }
                                aux = (aux - r) / 10;
                            }
                            c = c + 1;
                        }
                        Console.Write(ac);
                        Console.ReadKey();
                        break;
                    case 1://ESTRICTAMENTE CRECIENTE (o)
                        Loop = true;
                        Console.Clear();


                        var arreglo = LlenarArreglo();
                        Ordenamiento(arreglo);
                        Console.ReadKey();

                        //Llenar arreglo[]
                        static int[] LlenandoArreglo()
                        {
                            int[] arreglo = new int[5];
                            for (int i = 0; i < arreglo.Length; i++)
                            {
                                Console.Write("INGRESE NÚMERO: ");
                                arreglo[i] = int.Parse(Console.ReadLine());
                            }
                            return arreglo;
                        }
                        //Método de Ordenamiento
                        static void Ordenamiento(int[] A)
                        {
                            bool creciente = false, decreciente = false;
                            for (int i = 0; i<(A.Length - 1); i++)
                            {
                                if (A[i] < A[i+1]) creciente = true;//1 - 2 - 3 - 4 - 5
                                if (A[i] > A[i+1]) decreciente = true;// 25 - 4 - 3 - 2
                            }
                            if (creciente == true && decreciente == false) Console.WriteLine("\nEL ARREGLO ES CRECIENTE.");
                            else if (decreciente == true && creciente == false) Console.WriteLine("\nEL ARREGLO ES DECRECIENTE.");
                            //1-2-3-2-1
                            else if (creciente == true && decreciente == true) Console.WriteLine("\nEL ARREGLO ESTÁ DESORDENADO.");
                            //1-1-1-1-1
                            else if (creciente == false && decreciente == false) Console.WriteLine("\nLOS DATOS DEL ARREGLO SON IGUALES.");
                        }
                        Console.ReadKey();
                        break;


                    case 2://COMPRUEBA QUE EL ARREGLO ESTA CORRECTO DE MENOR A MAYOR(o)
                        Loop = true;
                        Console.Clear();

                        var arregla = LlenarArreglo();
                        Ordenamiento(arregla);
                        Console.ReadKey();

                        //Llenar arreglo[]
                        static int[] LlenandoArregla()
                        {
                            int[] arreglo = new int[5];
                            for (int i = 0; i < arreglo.Length; i++)
                            {
                                Console.Write("INGRESE NÚMERO: ");
                                arreglo[i] = int.Parse(Console.ReadLine());
                            }
                            return arreglo;
                        }
                        //Método de Ordenamiento
                        static void Ordenamienta(int[] A)
                        {
                            bool creciente = false, decreciente = false;
                            for (int i = 0; i<(A.Length - 1); i++)
                            {
                                if (A[i] < A[i+1]) creciente = true;//1 - 2 - 3 - 4 - 5
                                if (A[i] > A[i+1]) decreciente = true;// 25 - 4 - 3 - 2
                            }
                            if (creciente == true && decreciente == false) Console.WriteLine("\nTU ARREGLO ESTÁ CORRECTAMENTE DE MENOR A MAYOR");
                            else if (decreciente == true && creciente == false) Console.WriteLine("\nTU ARREGLO NO ESTA CORRECTAMENTE DE MENOR A MAYOR");
                            //1-2-3-2-1
                            else if (creciente == true && decreciente == true) Console.WriteLine("\nTU ARREGLO ESTÁ DESORDENADO PADRINO");
                            //1-1-1-1-1
                            else if (creciente == false && decreciente == false) Console.WriteLine("\nPILAS PORQUE TODOS LOS NÚMEROS EN TU ARREGLO SON IGUALES");
                        }
                        Console.ReadKey();

                        break;


                    case 3://INTERCAMBIA VECTORES (o)
                        Loop = true;
                        Console.Clear();

                        var Arreglo = LlenarArreglo();
                        Desplazamiento(Arreglo);
                        Console.ReadLine();


                        //LLenandoArreglo
                        static int[] LlenarArreglo()
                        //Desplazamiento

                        {
                            int[] A = new int[10];
                            for (int i = 0; i<A.Length; i++)
                            {
                                Console.Write("INGRESE NÚMERO[" + i + "]: ");
                                A[i] = int.Parse(Console.ReadLine());
                            }
                            return A;
                        }
                        //Desplazamiento
                        static void Desplazamiento(int[] arreglo)
                        {
                            int ultimo;
                            ultimo = arreglo[0];
                            // 0 - 9
                            for (int i = 8; i >= 0; i--)//8,7,6,5,4,3,2,1,0
                            {
                                arreglo[i + 1] = arreglo[i];//[9] = [8], [8] = [7], .. .. , [1] = [0]
                            }
                            arreglo[9] = ultimo;
                            Console.WriteLine("\nDesplazamiento de una posición en el arreglo[]: ");
                            for (int i = 0; i < arreglo.Length; i++)
                            {
                                Console.WriteLine("[" + i + "] número: " + arreglo[i]);
                            }
                        }
                        break;


                    case 4://NÚMEROS REPETIDOS (x)
                        Loop = true;
                        Console.Clear();
                        Console.Write("INGRESE SERIE DE DE NÚMEROS: ");

                        static void Main(string[] args)
                        {
                            int i = 0, c = 0;
                            string s = Console.ReadLine();

                            Console.WriteLine("\nDE LA LISTA ¿QUÉ NÚMERO DESEA SABER SI SE REPITE?: ");

                            char r = char.Parse(Console.ReadLine());
                            while (i < s.Length)
                            {
                                if (s[i] == r)
                                {
                                    c = c + 1;
                                }
                                i = i + 1;
                            }
                            Console.Write($"\nEN LA LISTA {r} SE REPITE {c} VECES");
                            Console.ReadKey();
                        }

                        break;


                    case 5://ENCONTRAR EL NÚMERO SOLICITADO DE ENTRE LA LISTA(o)
                        Loop = true;
                        Console.Clear();

                        int[] datos = { 10, 25, 40, 55, 80, 103, 110, 112 };
                        Console.WriteLine("¿QUE NÚMERO QUIERES BUSCAR?: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        bool encontrado = false;
                        int izquierda = 0, derecha = datos.Length - 1;
                        while (izquierda <= derecha && !encontrado)
                        {
                            int medio = izquierda + (derecha - izquierda) / 2;
                            if (datos[medio] == num)
                                encontrado = true;
                            else if (datos[medio] < num)
                                izquierda = medio + 1;
                            else
                                derecha = medio - 1;
                        }
                        if (encontrado)
                            Console.WriteLine("EN EFECTO MI ESTIMADO INGE, SE ENCUENTRA");
                        else
                            Console.WriteLine("NO SE ENCUENTRA");

                        break;


                    case 6://PROMEDIO DE UN VECTOR (o)
                        Loop = true;


                        int elem1, elem2, elem3, elem4, elem5;

                        Console.Clear();

                        Console.Write("INGRESE ELEMENTO [1]: ");
                        elem1 = int.Parse(Console.ReadLine());

                        Console.Write("INGRESE ELEMENTO [2]: ");
                        elem2 = int.Parse(Console.ReadLine());

                        Console.Write("INGRESE ELEMENTO [3]: ");
                        elem3 = int.Parse(Console.ReadLine());

                        Console.Write("INGRESE ELEMENTO [4]: ");
                        elem4 = int.Parse(Console.ReadLine());

                        Console.Write("INGRESE ELEMENTO [5]: ");
                        elem5 = int.Parse(Console.ReadLine());

                        double promedio = Convert.ToDouble(elem1 + elem2 + elem3 + elem4 + elem5) / 5;
                        Console.Write("\nEL PROMEDIO DEL VECTOR ES: " + promedio);


                        Console.ReadKey();
                        break;
                }
            }
        }

        private static string Menu(string[] items, int opcion)
        {
            string SeleccionActual = string.Empty;
            int destacado = 0;

            Array.ForEach(items, element =>
            {
                if (destacado == opcion)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(" > " + element + " < ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    SeleccionActual = element;
                }

                else
                {
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.CursorLeft = 0;
                    Console.WriteLine(element);
                }
                destacado++;
            });

            return SeleccionActual;
        }

    }
}