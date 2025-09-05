using System;

namespace TJ1
{
    public class TJ1sUtilityFunctions
    {
        public static string input(params object[] text) {
            Console.Write(string.Join(" ",text));
            return Console.ReadLine();
        }

        public static void print(params object[] text) {
            Console.WriteLine(string.Join(" ",text));
        }

    }
    
}


