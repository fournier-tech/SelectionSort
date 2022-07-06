using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //print array of integers
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
        //      if min != i then
        //         swap A[min] and A[i]

        public static void SelectionSort(int[] integerArray) {
            int n = integerArray.Length;
            for (int i = 0; i < n; i++) {
                int min = i;
                for (int j = i + 1; j < n; j++) {
                    if (integerArray[j] < integerArray[min]) {
                        min = j;
                    }
                }
                if (min != i) {
                    int temp = integerArray[min];
                    integerArray[min] = integerArray[i];
                    integerArray[i] = temp;
                }
            }
        }
    }
}