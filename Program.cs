using System;
using Chatbot;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Simple Chatbot!");
        var cbot = new Chatbot.Chatbot();
        while (true)
        {
            Console.Write("You: ");
            string userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput) || userInput.ToLower() == "exit")
            {
                break;
            }
            Console.WriteLine("Chatbot: ");
            Console.WriteLine(cbot.GetResponse(userInput));
            
        }
        Console.WriteLine("Goodbye!");
        Console.ReadLine();
    }
}