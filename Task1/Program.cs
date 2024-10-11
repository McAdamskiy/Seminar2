using System;

public class Answer
{
    static void Checking(int a){
        if(a % 7 == 0 && a% 23 == 0){
            Console.WriteLine("Da");
        }
        else Console.WriteLine("Net");
    }

    static public void Main(){
        Console.Write("a= ");
        int a = Convert.ToInt32(Console.Read());
        Checking(a);
    }
}