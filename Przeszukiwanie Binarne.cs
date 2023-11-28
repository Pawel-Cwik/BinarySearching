using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
namespace projekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            Random randomN = new Random();
            int numberOfTables = 10;
            List<int[]> listOfTables = new List<int[]>();
            for (int i = 0; i < numberOfTables; i++)
            {
                int tableSize = (i + 1) * 10000000;
                int[] newTable = new int[tableSize];
                for (int j = 0; j < tableSize; j++)
                {
                    newTable[j] = rnd.Next();
                }
                listOfTables.Add(newTable);
            }
            int computationalComplexity = 0;
            for (int j = 0; j < numberOfTables; j++)
            {

                Array.Sort(listOfTables[j]);
                // Przeszukiwanie binarne dla maksymalnej wartości tablicy
                var left = 0;
                var right = listOfTables[j].Length;
                int middle;
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                while (left <= right)
                {
                    middle = (left + right) / 2;
                    if (listOfTables[j][middle] == listOfTables[j][listOfTables[j].Length - 1])
                    {
                        computationalComplexity++;
                        stopWatch.Stop();
                        TimeSpan timeOfBinarySearching = stopWatch.Elapsed;
                        Console.WriteLine($"Znaleziono poszukiwaną wartość tablicy o wielkosci {listOfTables[j].Length} | Wartość:{listOfTables[j][middle]}");
                        Console.WriteLine($"Czas na wykonanie operacji: {timeOfBinarySearching} | Złożoność obliczeniowa: {computationalComplexity}");
                        computationalComplexity = 0;
                        break;
                    }
                    else if (listOfTables[j][middle] > listOfTables[j][listOfTables[j].Length - 1])
                    {
                        right = middle - 1;
                        computationalComplexity++;
                    }
                    else
                    {
                        left = middle + 1;
                        computationalComplexity++;
                    }
                }


                /* // Przeszukiwanie binarne dla losowo wybieranych wartości
                 int random = randomN.Next(0, listOfTables[j].Length);
                 var left = 0;
                 var right = listOfTables[j].Length;
                 int middle;
                 Stopwatch stopWatch = new Stopwatch();
                 stopWatch.Start();
                 while (left <= right)
                 {
                     middle = (left + right) / 2;
                     if (listOfTables[j][middle] == listOfTables[j][random])
                     {
                         computationalComplexity++;
                         stopWatch.Stop();
                         TimeSpan timeOfBinarySearching = stopWatch.Elapsed;
                         Console.WriteLine($"Znaleziono poszukiwaną wartosc tablicy o wielkosci: {listOfTables[j].Length} | Wartość: {listOfTables[j][middle]}");
                         Console.WriteLine($"Czas na wykonanie operacji: {timeOfBinarySearching} | Złożoność obliczeniowa: {computationalComplexity}");
                         computationalComplexity = 0;
                         break;
                     }
                     else if (listOfTables[j][middle] > listOfTables[j][random])
                     {
                         right = middle - 1;
                         computationalComplexity++;
                     }
                     else
                     {
                         left = middle + 1;
                         computationalComplexity++;
                     }
                 }
                 */

            }
            

        }



    }
}