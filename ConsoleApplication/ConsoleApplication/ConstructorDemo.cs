using System;
namespace ConsoleApplication
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            ConstructorDemo obj = new ConstructorDemo();
            Console.WriteLine($"i={obj.i}");
            Console.WriteLine($"b={obj.b}");
            if (obj.s == null)
            {
                Console.WriteLine("s == null");
            }
            Console.ReadKey();

        }
    }
    public class ConstructorDemo
	{
        public int i;
        public bool b;
        public string s;
	}
}

