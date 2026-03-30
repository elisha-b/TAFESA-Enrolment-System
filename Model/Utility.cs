using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System.Model
{
    public class Utility
    {
        // Linear Search Array
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;
            while (!found && i < array.Length)
            {
                if (target.CompareTo(array[i]) == 0)
                    found = true;
                else
                    i++;
            }
            if (i < array.Length)
                return i;
            else
                return -1;
        }

        // Binary Search Array
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = array[mid].CompareTo(target);

                if (comparison == 0)
                    return mid;
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
        // ASC - Bubble Sort
        public static void AscBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            T temp;

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        // DEC - Bubble Sort
        public static void DecBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            T temp;

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[j].CompareTo(array[i]) < 0)
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
