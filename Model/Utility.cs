using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System.Model
{
    public class Utility
    {
        /// PSEUDOCODE - Linear Search Array
        /// 
        /// FUNCTION LinearSearchArray(array, target)
        ///     SET i = 0
        ///     SET found = false
        ///     WHILE found IS false AND i IS LESS THAN array.Length
        ///         IF target IS EQUAL to array[i]
        ///             SET found = true
        ///         ELSE
        ///             INCREMENT i
        ///     IF i IS LESS THAN array.Length
        ///         RETURN i
        ///     ELSE
        ///         RETURN -1

        /// <summary>
        /// Linear Search Array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            try
            {
                if (array == null)
                {
                    throw new ArgumentNullException(nameof(array));
                }

                int i = 0;
                bool found = false;
                while (!found && i < array.Length)
                {
                    if (target.CompareTo(array[i]) == 0)
                    {
                        Console.WriteLine("The following was successfully found:\n\n" + target);
                        found = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (i < array.Length)
                {
                    return i;
                }
                else
                {
                    Console.WriteLine("Not found.");
                    return -1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
                return -1;
            }
        }

        /// PSEUDOCODE - Binary Search Array
        ///
        /// FUNCTION BinarySearchArray(array, target)
        ///     SET min = 0
        ///     SET max = array.Length - 1
        ///     
        ///     DO
        ///         SET min = (min + max) DIVIDED BY 2
        ///         SET comparison = array[mid].CompareTo(target)
        ///         
        ///         IF comparison IS 0
        ///             RETURN mid
        ///         ELSE IF comparison IS LESS THAN 0
        ///             SET min = mid + 1
        ///         ELSE
        ///             SET max = mid + 1
        ///     UNTIL min > max
        ///     
        ///     RETURN -1

        /// <summary>
        /// Binary Search Array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            try
            {
                if (array == null)
                {
                    throw new ArgumentNullException(nameof(array));
                }

                int min = 0;
                int max = array.Length - 1;
                int mid;

                do
                {
                    mid = (min + max) / 2;
                    int comparison = array[mid].CompareTo(target);

                    if (comparison == 0)
                    {
                        Console.WriteLine("The following was successfully found:\n\n" + target);
                        return mid;
                    }
                    else if (comparison < 0)
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        max = mid - 1;
                    }
                } while (min <= max);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
                return -1;
            }

            Console.WriteLine("Not found.");
            return -1;
        }

        /// <summary>
        /// ASC - Bubble Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void AscBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            T temp;

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        
        /// <summary>
        /// DEC - Bubble Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void DecBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            T temp;

            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) < 0)
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
