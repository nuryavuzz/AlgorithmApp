using SortingAlgorithm.Interfaces;
using SortingAlgorithm.Models;
using System;
using System.Diagnostics;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            ISortingAlgorithm bubbleSortAlgorithm = new BubbleSortAlgorithm();
            SubMain(bubbleSortAlgorithm); 
            ISortingAlgorithm insertionSortAlgorithm = new InsertionSortAlgorithm();
            SubMain(insertionSortAlgorithm);
            ISortingAlgorithm selectionSortAlgorithm = new SelectionSortAlgorithm();
            SubMain(selectionSortAlgorithm);
            Console.ReadKey();
        }
        public static void SubMain(ISortingAlgorithm sortingAlgorithm)
        {
            Stopwatch stopwatch = new Stopwatch(); 
            stopwatch.Start();
            int elementCount = 25000;
            int[] Array = new int[elementCount];
            Random random = new Random();
            for (int i = 0; i < elementCount - 1; i++)
            {
                int randomSayi = random.Next(1, 9999);
                Array[i] = randomSayi;
            }
            int[] siralanmisArray = sortingAlgorithm.SortASC(Array);
            stopwatch.Stop();
            Console.WriteLine("------------------------------------------------------------"); 
            Console.WriteLine(sortingAlgorithm.Name + " | " + stopwatch.ElapsedMilliseconds); 
            Console.WriteLine(string.Join(",",siralanmisArray));
        }
    }
}
