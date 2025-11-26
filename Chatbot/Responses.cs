using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Chatbot
{
    public static class Responses
    {
        // Predefined responses for specific keywords using a dictionary or hash map
        private static readonly Dictionary<string, string> predefinedResponses = new Dictionary<string, string>();
            static Responses()
        {
            string filePath = "Chatbot/predefinedResponses.txt";
            if (File.Exists(filePath))
            {
                foreach(var line in File.ReadAllLines(filePath))
                {
                    if (string.IsNullOrWhiteSpace(line)|| !line.Contains("=")) continue;
                    var parts = line.Split(new[] {'='}, 2);
                    var keyword = parts[0].Trim().ToLower();
                    var response = parts[1].Trim();
                    predefinedResponses[keyword] = response;
                }
            }
        }

        public static string GetResponse(string userInput)
        {
            userInput = userInput.ToLower().Trim();
            if (userInput == "/help")
            {
                var actions = predefinedResponses.Keys
                    .Where(k => !k.StartsWith("/"))
                    .OrderBy(k => k)
                    .Select(k => $"- {k}")
                    .ToList();
                return "This is the list of actions I can do:\n " + string.Join("\n", actions);
            }
            foreach (var pair in predefinedResponses)
            {
                if (userInput.Contains(pair.Key))
                {
                    var response = pair.Value;
                    // Replace placeholders
                    response = response.Replace("{date}", DateTime.Now.ToString("yyyy-MM-dd"));
                    response = response.Replace("{time}", DateTime.Now.ToString("HH:mm:ss"));
                    return response;
                }
            }
            return "I'm not sure how to respond to that. Can you please clarify?";
        }
    }
}