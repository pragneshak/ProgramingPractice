namespace ConsoleApplication;

public class Program
{
    public static void Main(string[] args)
    {
        //Calculator calObj = new Calculator();
        //int result = calObj.Calculatesum(10, 20);
        //Console.WriteLine(result);

        //For method overriding and method hiding
        //Child obj = new Child();
        //obj.Show();
        //obj.Display();

        //For Optional Parameter using Parameter array
        //ADDNumbers(10, 20);
        //ADDNumbers(10, 20, 30, 40, 50);
        //ADDNumbers(1, 2, new object[] { 3, 4, 5 });

        //Optional Parameter using Method Overloading
        ADDNumbers(11, 22,new int[] {33,44});
      //  ADDNumbers(11, 22, null);//null is not working need to overload method with only 2 parameters
        ADDNumbers(11, 22);

        Console.ReadKey();
    }
    //For Optional Parameter using Parameter array
    //public static void ADDNumbers(int FN, int SN, params object[] restOfTheNumbers)
    //{
    //    int result = FN + SN;
    //    foreach (int i in restOfTheNumbers)
    //    {
    //        result += i;
    //    }
    //    Console.WriteLine("Total = " + result.ToString());
    //}

    //Optional Parameter using Method Overloading
    public static void ADDNumbers(int FN, int SN, int[] restOfTheNumbers)
    {
        int result = FN + SN;
        foreach (int i in restOfTheNumbers)
        {
            result += i;
        }
        Console.WriteLine("Total = " + result.ToString());
    }
    public static void ADDNumbers(int FN, int SN)
    {
        int result = FN + SN;
        Console.WriteLine("Total = " + result.ToString());
    }

    //Specify parameter defaluts
}
public class Calculator
{
    public int Calculatesum(int no1,int no2)
    {
        return no1 + no2;
    }
}

