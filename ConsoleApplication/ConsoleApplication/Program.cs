namespace ConsoleApplication;

public class Program
{
    public static void Main(string[] args)
    {
        //Calculator calObj = new Calculator();
        //int result = calObj.Calculatesum(10, 20);
        //Console.WriteLine(result);
        //Console.ReadKey();

        //For method overriding and method hiding
        Child obj = new Child();
        obj.Show();
        obj.Display();
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

