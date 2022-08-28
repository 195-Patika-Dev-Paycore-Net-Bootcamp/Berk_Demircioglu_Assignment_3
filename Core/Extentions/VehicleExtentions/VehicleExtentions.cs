using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extentions.VehicleExtentions
{
    public static class VehicleExtentions
    {
        //This extension is created to partition containers of the related vehicle with respect to a given chunk size.

        /// <summary>
        ///Step 1: The logic behind this is that, for instance, there are 16 containers that belong to a vehicle and we want to split these containers into 5 separate groups.
        ///Step 2: If we divide 16 by 5, we obtain a quotient of 3. This quotient indicates that my first list length will be 3.
        ///Step 3: Then 16-3=13 containers and 4 groups remain to be partitioned. If we apply the same method stated in Step 2 to these parameters. 
        ///        We obtain the quotient as 13/4=3. Then my second list contains 3 number of elements. And so on.
        /// 
        /// The algorithm;
        /// 
        /// 16 / 5 = 3 => list length = 3 && 16 - 3 = 13  
        /// 13 / 4 = 3 => list length = 3 && 13 - 3 = 10
        /// 10 / 3 = 3 => list length = 3 && 10 - 3 = 7
        ///  7 / 2 = 3 => list length = 3 && 7 - 3 = 4
        ///  4 / 1 = 4 => list length = 4 && 4 - 4 = 0
        /// ---------------------------------------------
        /// For example 13 container, 7 group;
        /// 13 / 7 = 1 => list length = 1 && 13 - 1 = 12  
        /// 12 / 6 = 2 => list length = 2 && 12 - 2 = 10
        /// 10 / 5 = 2 => list length = 2 && 10 - 2 = 8
        ///  8 / 4 = 2 => list length = 2 && 8 - 2 = 6
        ///  6 / 3 = 2 => list length = 2 && 6 - 2 = 4
        ///  4 / 2 = 2 => list length = 2 && 4 - 2 = 2
        ///  2 / 1 = 2 => list length = 2 && 2 - 2 = 0
        /// </summary>

        public static List<List<T>> PartitionContainers<T>(this List<T> givenList, int chunkSize)
        {
            var resultList = new List<List<T>>(); //Result list is created.
            var clonedList = givenList.ToList(); // The given list is cloned to prevent dislocation. Because lists are referenced variables. 
            for (int i = chunkSize; i > 0; i--) // Group number is decreased step by step as mentioned above.
            {
                int quotient = (int)clonedList.Count / i; // The quotient = the list length
                var instantList = clonedList.Take(quotient).ToList(); // The elements are taken from the main list with respect to the found list size.
                resultList.Add(instantList); // The elements are added to result list as a list.
                foreach (var item in instantList)
                {
                    clonedList.Remove(item); // The selected elements are removed from the list. The next selection will be made within the remaining elements.
                }
            }
            return resultList;
        }
    }
}
