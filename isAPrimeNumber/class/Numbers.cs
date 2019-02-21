using System;
using System.Collections.Generic;
using System.Text;

namespace isAPrimeNumber
{
    public class Numbers
    {
        public static bool isAPrimeNumber(int num)
        {
            bool returnMsg = false;

            for (int i = 2; i <= num; i++)
            {
                if ((num % i) == 0 && num != i)

                {
                    returnMsg = false;
                    return returnMsg;
                }
                else if (num == i)
                {
                    returnMsg = true;
                    return returnMsg;
                }
            }
            return returnMsg;
        }
    }
}
