using System;

namespace Lib_4
{
    public class Practice
    {
        public static int MiniNumber(int count, out int min, out string numbers)
        {
            min = 40;
            int number;
            numbers = "";
            Random randomNumber = new Random();
            for (int i = 0; i < count; i++)
            {
                number = randomNumber.Next(10, 40);
                numbers += " " + number;

                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
