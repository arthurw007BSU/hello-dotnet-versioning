﻿namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        var number = int.Parse(Console.ReadLine());

        if(number%2 ==0){
            Console.WriteLine("The number is even!");

        }else {
            Console.WriteLine("The number is odd!");
        }


    }
}
