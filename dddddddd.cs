using System.ComponentModel.Design;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Student s1 = new Student(1, "Reuven", 'm', "YA3");
        Student s2 = new Student(1, "Shimon", 'e', "YA3");

        s1.SetGrade(80);
        s2.SetGrade(90);
        if (s1.BestGrade(s2)) ;
        {
            Console.WriteLine(s1.GetName() + "is better");
        }
        else
        {
            Console.WriteLine(s2.GetName() + " is better");
        }
        Console.WriteLine(s1);  
    }
}