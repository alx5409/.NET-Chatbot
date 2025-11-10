using System;

namespace Chatbot
{
    public static class Responses
    {
        public static string GetResponse(string userInput)
        {
            userInput = userInput.ToLower();
            if (userInput.Contains("hello") || userInput.Contains("hi"))
            {
                return "Hello! How can I assist you today?";
            }
            else if (userInput.Contains("help"))
            {
                return "Sure! What do you need help with?";
            }
            else
            {
                return "I'm not sure how to respond to that. Can you please clarify?";
            }
        }
    }
}