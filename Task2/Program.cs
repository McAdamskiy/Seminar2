﻿using System;

public class Answer{
    static void Chetvert(int x, int y){
        if(x > 0 && y > 0){
            Console.WriteLine(1);
        }
        else if(x < 0 && y > 0){
            Console.WriteLine(2);
        }
        else if(x < 0 && y < 0){
            Console.WriteLine(3);
        }
        else{
            Console.WriteLine(4);
        }
    }
    static public void Main(){
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        
        Chetvert(x, y);
    }
}