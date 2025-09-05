using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tj1
{
    public class TJ1sUtilityFunctions
    {
        // tj means that it is a function, which I made, because I like to do it like this, for example with tj_input has a " --> " in it
        public static string input(params object[] text) // works exactly the same way like in Python
        {
            Console.Write(string.Join(" ",text));
            return Console.ReadLine();
        }

        public static string tj_input(params object[] text) // input with " --> "
        {
            Console.WriteLine(string.Join(" ", text));
            Console.Write(" --> ");
            return Console.ReadLine();
        }

        public static void print(params object[] text) // works almost! the same way like in Python, it doesn't have f string, cause I would need to make a tokenizer for that and I don't know how to do that yet.
        {
            Console.WriteLine(string.Join(" ",text));
        }

        public static void list_arrays_children<T>(params T[] array) // prints out all of the children of an array, this is good for debuggin purposes 
        {
            print("Array's children:");
            foreach (var child in array)
            {
                print("-",child?.ToString() ?? "null");
            }
        }
    }
}
