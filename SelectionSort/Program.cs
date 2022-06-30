using System;
using System.Web;
using System.Threading;

namespace SelectionSort {
    class Program {

        static void Main(string[] args) {

            //arbitrary list of unsorted integers
            int[] integerArray = { 6, 5, -6, 0, 3, 10, 4, 6, -5, 0 };
            int lowIndex = 0;
            int highIndex = integerArray.Length - 1;

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

        public static void SelectionSort(int[] integerArray) {
            int n = integerArray.Length;
            for (int i = 0; i < n; i++) {
                int min = i;
                for (int j = i + 1; j < n; j++) {
                    if (Less(integerArray[j], integerArray[min])) {
                        min = j;
                    }
                }
                Exchange(integerArray, i, min);
            }
        }

        public static void Exchange(int[] integerArray, int min, int max) {
            int temp = integerArray[min];
            integerArray[min] = integerArray[max];
            integerArray[max] = temp;
        }

        public static bool Less(int a, int b) {
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