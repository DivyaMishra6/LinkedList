﻿namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            Console.WriteLine("**********************************");

            Console.WriteLine("Welcome to Linkedlist problem!");
            Console.WriteLine("**********************************");
            List list = new List();
            list.Add(56);
            Console.WriteLine("Node with data 56 is First Created");
            Console.WriteLine(" ");
            list.Add(30);
            Console.WriteLine("Next Append 70 to 56");
            Console.WriteLine(" ");
            list.Add(70);
            Console.WriteLine("Finally Append 70 to 30");
            Console.WriteLine(" ");
           
            Console.WriteLine("LinkedList Sequence:");
            list.Display();

            list.Delete();
            Console.WriteLine("After delete first element ");
            Console.WriteLine("LinkedList Sequence:");
            list.Display();

        }
    }
}