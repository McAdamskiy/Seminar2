using System;

public class Answer{
    static void Main(){
        string input = Console.ReadLine();
        string result = string.Join(", ", input.ToCharArray());
        Console.WriteLine(result);
    }
}