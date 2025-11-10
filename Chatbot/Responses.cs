using System;

namespace Chatbot
{
    public static class Responses
    {
        private static readonly Dictionary<string, string> predefinedResponses = new Dictionary<string, string>
        {
            { "hello", "Hello! How can I assist you today?" },
            { "hi", "Hello! How can I assist you today?" },
            { "help", "Sure! What do you need help with?" }
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