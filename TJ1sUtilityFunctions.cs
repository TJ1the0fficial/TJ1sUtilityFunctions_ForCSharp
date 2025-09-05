using System;

namespace Learning_II
{
    public class AbdisUtilityFunctions
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
