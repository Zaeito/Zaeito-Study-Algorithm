using System;

public class Example
{
    public static void Main(string[] args)
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        char[] tempArray = s.ToCharArray();
        foreach(char ch in tempArray)
        {
            Console.WriteLine(ch);
        }

    }
}