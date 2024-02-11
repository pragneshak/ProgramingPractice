using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
	public class OptionalParamSpecify
	{   
            static void Main(string[] args)
            {
                //Adding two Integer Numbers
                ADDNumbers(10, 20);

                //Adding Five Integer Numbers
                ADDNumbers(10, 20, new int[] { 30, 40, 50 });

            ADDNumbers2(4, 5, new int[] { 6 });
            ADDNumbers2(9, 10);
                Console.ReadLine();
            }

        //Method Parameters Optional by Specifying Parameter Defaults
        public static void ADDNumbers(int FN, int SN, int[]? restOfTheNumbers = null)
            {
                int result = FN + SN;
                //Loop through the restOfTheNumbers only if it is not null
                //else we will get runtime error
                if (restOfTheNumbers != null)
                {
                    foreach (int i in restOfTheNumbers)
                    {
                        result += i;
                    }
                }

                Console.WriteLine("Total = " + result.ToString());
            }

        // Parameter Optional Using OptionalAttribute in C#:

        public static void ADDNumbers2(int FN,int SN, [Optional] int[] restOfTheNumbers)
        {
            int result = FN + SN;
            if(restOfTheNumbers != null)
            {
                foreach(int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }
}



