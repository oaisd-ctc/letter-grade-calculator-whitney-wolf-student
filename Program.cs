using System;

class Program
{
    public static void Main(string [] args)
    {
        Scores ();
    }

    public static void Scores() 
    {
        Console.WriteLine("Enter your grade score in class:");
        int score = int.Parse(Console.ReadLine()!);
    
        if (score >= 100)
        {
            Console.WriteLine ("Letter Grade: A+");
            Console.WriteLine ("Wow! 100.. That's impressive!");
        }
        else if (score >= 90)
        {
            Console.WriteLine ("Letter Grade: A");
            Console.WriteLine ("Very Nice!");
        }
        else if (score >= 80)
        {
            Console.WriteLine ("Letter Grade: B");
            Console.WriteLine ("Keep it up!");
        }
        else if (score >= 70)
        {
            Console.WriteLine ("Letter Grade: C");
            Console.WriteLine ("You got this, keep working!");
        }
        else if (score >= 60)
        {
            Console.WriteLine ("Letter Grade: D");
            Console.WriteLine ("Keep trying!");
        }
        else
        {
            Console.WriteLine ("Letter Grade: E");
            Console.WriteLine ("Don’t give up!");
        }
        
    }
}
