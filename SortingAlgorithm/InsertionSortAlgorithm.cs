using SortingAlgorithm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Models
{
    public class InsertionSortAlgorithm : ISortingAlgorithm 
    {
        public string Name => "Insertion Sort Algorithm";

        public int[] SortASC(int[] intArray)
        {
            for (int i = 0; i < intArray.Count(); i++)
            {
                var item = intArray[i];
                var currentIndex = i;

                while (currentIndex > 0 && intArray[currentIndex - 1] > item)
                {
                    intArray[currentIndex] = intArray[currentIndex - 1];
                    currentIndex--;
                }

                intArray[currentIndex] = item;
            }
            return intArray; 
        }

        public int[] SortDESC(int[] intArray)
        {
            throw new NotImplementedException();
        }
    }
}
