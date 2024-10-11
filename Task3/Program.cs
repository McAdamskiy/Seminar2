using System;

public class Answer{
    static void Sifra(int a){
        int a1, a2;
        a1 = a/10;
        a2 = a%10;
        if(a1>a2){
            Console.WriteLine(a1);
        }
        else Console.WriteLine(a2);
    }
    static void Main(){
        int a = Convert.ToInt32(Console.ReadLine());
        Sifra(a);
    }
}