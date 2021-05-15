using SortingAlgorithm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Models
{
    public class SelectionSortAlgorithm : ISortingAlgorithm
    {
        public string Name => "Selection Sort Algorithm";

        public int[] SortASC(int[] intArray)
        {
            for (var i = 0; i < intArray.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[min] > intArray[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var lowerValue = intArray[min];
                    intArray[min] = intArray[i];
                    intArray[i] = lowerValue;
                }
            }
            return intArray;
        }

        public int[] SortDESC(int[] intArray)
        {
            throw new NotImplementedException();
        }
    }
}
