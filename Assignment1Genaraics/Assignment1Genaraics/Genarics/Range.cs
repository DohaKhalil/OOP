using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Genaraics.Genarics
{
    internal class Range<T> where T: IComparable<T> 
    {
        public T Minimumvalue  { get; set; }
        public T Maximum { get; set; }

      public Range(T minimumvalue, T maximum)
      {
            Minimumvalue = minimumvalue;
            Maximum = maximum;
      }

        public Range()
        {
        }

        //Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
        public bool IsRange (T value)

        {
            
          return value.CompareTo(Minimumvalue) <= 0 && value.CompareTo(Maximum) >=0;
            
        }

        //Implement a method Length() that returns the length of the range
        //(the difference between the maximum and minimum values).

        public static dynamic Length<T> ( T Max , T Min)
        {
            dynamic MaxValue = Max;
            dynamic MinValue = Min;
            dynamic ret;
            try
            {
                ret = MaxValue - MinValue;

                return ret;
               

            }catch (Exception ex)
            {
                return(ex.Message);
                
            }
        }
        public static void PrintValue(int value1 , int value2)
        {
          Console.WriteLine(value1 + " " + value2);
            
        }

    }
}
