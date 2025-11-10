using System;

namespace Chatbot
{
    public class Chatbot
    {
        public string GetResponse(string userInput)
        {
            return Responses.GetResponse(userInput);
        }
    }
}