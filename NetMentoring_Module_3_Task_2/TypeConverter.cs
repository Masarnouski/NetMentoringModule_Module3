using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetMentoring_Module_3_Task_2
{
    public class TypeConverter
    {
        public int ConvertStringToInt(string inputString)
        {
            var isNegative = false;
            if (string.IsNullOrEmpty(inputString))
            {
                throw new ArgumentException("Input string is null or whitespace");
            }
            var number = 0;
            if (inputString[0] == 45)
            {
                isNegative = true;
                inputString = inputString.Remove(0, 1);
            }
            foreach (var symbol in inputString)
            {
                if (char.IsDigit(symbol))
                {
                    number = checked(number * 10 + ((int)symbol - 48));
                }
                else
                {
                    throw new FormatException();
                }
            }
            if (isNegative)
            {
                var result = number * (-1);
                return result;
            }
            else
            {
                return number;               
            }
        }
    }
}
