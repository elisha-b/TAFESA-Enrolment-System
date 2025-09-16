using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Utility
    {
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
    }
}
