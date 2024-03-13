using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Lab7Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the food queue
            Queue<string> food = new Queue<string>();

            // adding foods
            food.Enqueue("Pepperoni Pizza");
            food.Enqueue("Cheese Burger");
            food.Enqueue("Sub Sandwich");
            food.Enqueue("Roast Beef");
            food.Enqueue("Prime Rib");

            // adding members
            Console.WriteLine("How many foods would you like to add?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Food name: ");
                food.Enqueue(Console.ReadLine());
            }

            // counts the food in the queue
            Console.WriteLine($"Here are your {food.Count()} foods");
            // displays the queue contents without removing anything
            foreach (var m in food)
            {
                Console.WriteLine(m);
            }



            // views first item in the queue and displays it to determine if the user wants to remove it
            string checkfood = food.Peek();
            //Console.WriteLine(firstFood);
            Console.WriteLine($"Would you like to remove {checkfood} from the beginning of the queue (yes or no)?");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                food.Dequeue(); // removed item from the top of queue
                checkfood = food.Peek();
                Console.WriteLine($"Would you like to remove {checkfood} from the beginning of the queue (yes or no)?");
                answer = Console.ReadLine();
            }

            if (food.Peek() == null)
                Console.WriteLine("The queue is empty");
           

            else
                Console.WriteLine($"You have {food.Count} left in the queue");



        }
    }

}
