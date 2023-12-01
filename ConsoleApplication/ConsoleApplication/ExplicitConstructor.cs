using System;
namespace ConsoleApplication
{ 
	public class ExplicitConstructor
	{
		public static void Main(string[] args)
		{
			CallExplicitConstructor obj = new CallExplicitConstructor();
			Console.ReadKey();
		}
        }
    public class CallExplicitConstructor
    {
        public CallExplicitConstructor()
        {
            Console.WriteLine("ExplicitConstructor");
        }
    }
}
