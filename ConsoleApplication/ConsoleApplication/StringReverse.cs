using System;
using System.Collections;

namespace ConsoleApplication
{
	public class StringReverse
	{
		public static string ReverseStr(string str)
		{
			char[] charArr = str.ToCharArray();
			Array.Reverse(charArr);
			return new string(charArr);
		}
		public static void Main(string[] args)
		{
			string toreverse = "Hello";
			string ans = ReverseStr(toreverse);

            Console.WriteLine(ans);
			Console.ReadKey();
		}
	}
}

