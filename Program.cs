// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string Tony = Console.ReadLine();
            Console.WriteLine($"Fuck you, {Tony}");
            Console.WriteLine($"What's your name?");
            string Ezekiel = Console.ReadLine();
            Console.WriteLine($"Fuck you, {Ezekiel}");
            
        }
    }
}