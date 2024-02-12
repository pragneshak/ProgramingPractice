using System;
namespace ConsoleApplication
{
	public class OccuranceCheck
	{
		public static int OccaranceCheck(string str,char ch)
		{
			int count = 0;
			foreach(char c in str){
				if (c == ch)
				{
					count++;
				}
			}
			return count;
		}
		public static void Main(string[] args)
		{
			string firstString = "hellohi";
			char charCheck = 'h';
			int Totalcount = OccaranceCheck(firstString, charCheck);
            Console.WriteLine(Totalcount);
			Console.ReadKey();
		}
	}
}
