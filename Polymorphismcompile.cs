using System;
class A
{
    int a = 20, b = 10;
    public void add()
    {
        int sum=a+b;
        Console.WriteLine(sum);
    }
    public void add(int a,int b)
    {
        int sum=a+b;
        Console.WriteLine(sum);
    }
}
class MainClass
{
    public static void Main()
    {
        A r=new A();
       r.add(40,60);
        r.add();     
    }
}
