using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Interfaces
{
    public interface ISortingAlgorithm
    {
        string Name { get; }
        int[] SortASC(int[] intArray); //Küçükten Büyüğe Sıralar 
        int[] SortDESC(int[] intArray); //Büyükten Küçüğe Sıralar  
    }
}
