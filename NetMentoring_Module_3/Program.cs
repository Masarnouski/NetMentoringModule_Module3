using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NetMentoring_Module_3_Task_2;

namespace NetMentoring_Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //  Task number #1
            //string inputString;
            //while (true)
            //{
            //    try
            //    {
            //        inputString = Console.ReadLine();

            //        if (string.IsNullOrEmpty(inputString))
            //        {
            //            Console.WriteLine("Input string is null or whitespace");
            //        }

            //        if (inputString == "quit")
            //            break;

            //        Console.WriteLine(inputString[0]);
            //    }

            //    catch(Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //}



            //Here you can test the library

            var typeConverter = new TypeConverter();
            string inputString;
            while (true)
            {
                try
                {
                    inputString = Console.ReadLine();
                    if (inputString == "quit")
                        break;
                    Console.WriteLine(typeConverter.ConvertStringToInt(inputString));
                }
                catch (Exception e)
                {
                    Console.WriteLine("There is error: " + e.Message);
                }
            }

        }

    }
}
