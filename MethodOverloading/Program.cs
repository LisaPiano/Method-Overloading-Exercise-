namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int x, int y)
        { 
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 5));
        }
    }
}
