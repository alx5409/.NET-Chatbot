using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Simple Chatbot!");
        while (true)
        {
            Console.Write("You: ");
            string userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput) || userInput.ToLower() == "exit")
            {
                break;
            }
            Console.WriteLine("Chatbot: ");
        }
        Console.WriteLine("Goodbye!");
        Console.ReadLine();
    }
}