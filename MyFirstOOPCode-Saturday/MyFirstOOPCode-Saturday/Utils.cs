using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    internal static class Utils
    {
        public static void Show<T>(List<T> Options) {
            Console.WriteLine("\n");
            foreach (T option in Options)
            {
                Console.WriteLine(option.ToString());
            }
        }

        public static int GetValueTypeInt(string OptionEnter) {
            try
            {
                Console.WriteLine($"\n Enter the {OptionEnter}");
                return  Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n The value entered is not valid \n");
                return GetValueTypeInt(OptionEnter);
            }
        }

        public static string GetValueTypeString(string OptionEnter)
        {
            try
            {
                Console.WriteLine($" \n Enter the {OptionEnter}");
                return Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("The value entered is not valid");
                return GetValueTypeString(OptionEnter);
            }
        }

        public static bool GetValueTypeBoolean(string OptionEnter)
        {
            try
            {   
                Console.WriteLine($" \n Enter the {OptionEnter}");
                Console.WriteLine("\"true\" : is active\r\n\"false\": is inactive");
                return Convert.ToBoolean(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n The value entered is not valid \n");
                return GetValueTypeBoolean(OptionEnter);
            }
        }

        public static decimal GetValueTypeDecimal(string OptionEnter)
        {
            try
            {
                Console.WriteLine($" \n Enter the {OptionEnter}");
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\n The value entered is not valid \n");
                return GetValueTypeDecimal(OptionEnter);
            }
        }
    }
}
