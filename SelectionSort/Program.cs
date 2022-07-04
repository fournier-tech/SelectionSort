using System;
using System.Web;
using System.Threading;

namespace SelectionSort {
    class Program {

        static void Main(string[] args) {

            //arbitrary list of unsorted integers
            int[] integerArray = { 6, 5, -6, 0, 3, 10, 4, 6, -5, 0 };

            Console.WriteLine("\nUnsorted List of Integers: ");
            PrintList(integerArray);
            Console.WriteLine("\nSorted List of Integers: ");
            SelectionSort(integerArray);
            PrintList(integerArray);
            Console.WriteLine("\n");
        }

        public static void PrintList(int[] integerArray) {

            foreach (int i in integerArray) {
                Console.Write(i + " ");
            }
            Console.WriteLine('\n');
        }

        //Selection Sort(A[])
        //   n = A.Length
        //   for i = 0 to n
        //      //set current element as the minimum
        //      min = i
        //      //check the element to be minimum
        //      for j = i + 1 to n 
        //         if list[j] < list[min] then
        //            min = j;
        //      // swap the minimum element with the current element*/
        //      if indexMin != i then
        //         swap list[min] and list[i]

        public static void SelectionSort(int[] integerArray) {

            for (int i = 0; i < integerArray.Length; i++) {
                int min = i;
                for (int j = i + 1; j < integerArray.Length; j++) {
                    //
                    if (CompareValues(integerArray[j], integerArray[min])) {
                        min = j;
                    }
                }
                SwapPosition(integerArray, i, min);
            }
        }

        public static void SwapPosition(int[] integerArray, int lower, int higher) {

            int temp = integerArray[lower];
            integerArray[lower] = integerArray[higher];
            integerArray[higher] = temp;
        }

        public static bool CompareValues(int a, int b) {
            bool c;
            if (a < b) {
                c = true;
            } else {
                c = false;
            }
            return c;
        }
    }
}