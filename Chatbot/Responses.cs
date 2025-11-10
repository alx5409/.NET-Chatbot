using System;
using System.Collections.Generic;

namespace Chatbot
{
    public static class Responses
    {
        // Predefined responses for specific keywords using a dictionary or hash map
        private static readonly Dictionary<string, string> predefinedResponses = new Dictionary<string, string>
        {
            { "hello", "Hello! How can I assist you today?" },
            { "hi", "Hello! How can I assist you today?" },
            { "help", "Sure! What do you need help with?" },
            { "how are you", "I'm just a bot, but I'm doing great! How are you?" },
            { "who are you", "I'm a simple chatbot created to assist you." },
            { "good morning", "Good morning! How can I help you?" },
            { "good afternoon", "Good afternoon! What can I do for you?" },
            { "bye", "Goodbye! Have a great day!" },
            { "goodbye", "Goodbye! Have a great day!" },
            { "see you", "See you next time!" },
            { "what can you do", "I can answer simple questions and have basic conversations." },
            { "date", $"Today's date is {DateTime.Now.ToShortDateString()}." },
            { "time", $"The current time is {DateTime.Now.ToShortTimeString()}." }
        };
        public static string GetResponse(string userInput)
        {
            userInput = userInput.ToLower();
            foreach (var pair in predefinedResponses)
            {
                if (userInput.Contains(pair.Key))
                {
                    return pair.Value;
                }
            }
            return "I'm not sure how to respond to that. Can you please clarify?";
        }
    }
}