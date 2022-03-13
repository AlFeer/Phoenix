using System;
using PhoenixSuns;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your player: ");
            Phoenix playername = new Phoenix(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        } 
    }
}