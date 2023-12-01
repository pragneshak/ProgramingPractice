namespace ConsoleApplication;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calObj = new Calculator();
        int result = calObj.Calculatesum(10, 20);
        Console.WriteLine(result);
        Console.ReadKey();
       
    }
}
public class Calculator
{
    public int Calculatesum(int no1,int no2)
    {
        return no1 + no2;
    }
}

