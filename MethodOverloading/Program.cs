using System.Reflection.Metadata.Ecma335;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int x, int y)
        { 
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isPlural)
        {
            if (isPlural && (x + y != 1))
            {
                return $"{x + y} dollars";
            }
            else if (isPlural && (x + y == 1))
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
        }








        //=============================================================================================================================
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));
        }
    }
}
