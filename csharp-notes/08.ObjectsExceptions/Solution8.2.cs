using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ObjectsExceptions
{
    class BadScaleError : System.Exception
    {

    }

    class Solution8
    {
        public static int GetTransactionValue(int scale)
        {
            if(scale < 2)
            {
                throw new BadScaleError();
            }

            Console.WriteLine("Transaction Value? ");
            string tv = Console.ReadLine();

            try
            {
                return scale * int.Parse(tv);
            }
            catch (FormatException ex)
            {
                return GetTransactionValue(scale);
            }
            catch (OverflowException ex)
            {
                return int.MaxValue;
            }
        }
        public static void Solution()
        {
            Console.WriteLine(GetTransactionValue(3));

            Console.WriteLine(GetTransactionValue(1));
        }
    }
}
