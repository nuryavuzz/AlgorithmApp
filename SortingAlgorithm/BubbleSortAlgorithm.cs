using SortingAlgorithm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Models
{
    public class BubbleSortAlgorithm : ISortingAlgorithm
    {
        public string Name => "Bubble Sort Algorithm";

        public int[] SortASC(int[] intArray)
        {
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < intArray.Count() - 1; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        var lowerValue = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
            return intArray;
        }

        public int[] SortDESC(int[] intArray)
        {
            throw new NotImplementedException();
        }
    }
}
