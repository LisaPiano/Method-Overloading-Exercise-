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








        //=============================================================================================================================
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4.5m, 5.5m));
        }
    }
}
