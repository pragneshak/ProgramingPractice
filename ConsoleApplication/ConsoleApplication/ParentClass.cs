using System;
namespace ConsoleApplication
{
	public class ParentClass
	{
		public virtual void Show()
		{
			Console.WriteLine("Parent class Show Method");
		}
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }
    public class Child : ParentClass
    {
        //Method Overriding
        //In Method Overriding, the child classes re-implement their parent class methods which are declared as virtual.
        //That means here, the child classes re-implement the parent class methods with the permission of the parent class because
        //here in the parent class the method is declared as virtual giving permission to the child classes for overriding the methods
        //using the override modifier.

        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
        //reimplementation of virtual method is also possible with new keyword i.e. Method Hiding.
        //public new void Show()
        //{
        //    Console.WriteLine("Child2 Class Show Method");
        //}
        //Method Hiding/Shadowing
        //In Method Hiding/Shadowing, the child classes can re-implement any method of its parent class methods even
        //if they are not declared as virtual.
        //That means here the child class re-implements the parent class methods without taking any permission from its parent.

        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
    }
}

