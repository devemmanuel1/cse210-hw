using System;

    public class  PromptGenerator
    {
        public List<string> _prompts = new List<string>();

        public string GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, _prompts.Count());

            string prompt = _prompts[number];

            return prompt;

        }
    }  