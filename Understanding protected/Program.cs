using System;

class A
{
    protected void MethodA()
    {
        Console.WriteLine("MethodA in class A is called.");
    }
}

class B : A
{
    protected void MethodB()
    {
        Console.WriteLine("MethodB in class B is called.");
    }

    public void CallMethodA()
    {
        // Class B can access the protected method of class A
        MethodA();
    }
}

class C : B
{
    private void MethodCAB()
    {
        Console.WriteLine("MethodC in class C is called.");

        // Class C can access the protected methods of class A and class B
        MethodA(); // Call protected method of class A through class B
        MethodB(); // Call protected method of class B directly (inherited)
    }

    public void CallMethodC()
    {
        // Class C can call its private method
        MethodCAB();
    }
}

class Program
{
    static void Main()
    {
        C c = new C();

        // Class C can call its own private method
        c.CallMethodC();

        // Class C can also call protected methods of class A and class B
        c.CallMethodA(); // Accessing MethodA of class A through class B (via public method)

        // Note that MethodB of class B (obj.) is not accessible from outside class B
    }
}
