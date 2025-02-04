/*
When we declare a delegate, behind the scene when the compiler sees the delegate keyword,
it will create a class inheriting from the MulticastDelegate and as this is a class,
we can create an instance of the delegate by using the new keyword. And notice to the constructor,
that we are passing the Delegate handler Method name.
*/


public delegate void WorkPerformedHandler(int hours, WorkType workType);
class Program
{
     static void Main(string[] args)
    {
        WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);
        //del1(10, WorkType.Golf);
        del1(10, WorkType.GoToMeetings);

        Console.ReadKey();
    }
    public static void Manager_WorkPerformed(int workHours,WorkType wType)
    {
        Console.WriteLine("Work Performed by Event Handler");
        Console.WriteLine($"Work Hours:{workHours},Work Type:{wType}");
    }
}
public enum WorkType
{
    Golf,
    GoToMeetings,
    GenerateReports
}