using System;
namespace ConsoleApplication
{
	public class RemoveFirst
	{
		public static string RemoveFirstOcc(string str, char ch){

			int index = str.IndexOf(ch);
			if(index != -1)
			{
				return str.Remove(index,1);
			}
			else
			{
				return str;
			}

		}

	public static void Main(string[] args) {
			string str = "whether";
			char charToremove = 'e';
			string Ans= RemoveFirstOcc(str, charToremove);
			Console.WriteLine(Ans);
			Console.ReadKey();
        }
	}
}

