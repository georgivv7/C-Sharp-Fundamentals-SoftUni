using System;

namespace _01._SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                var data = input.Split(":|:");
                string command = data[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(data[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine($"{message}");
                        break;
                    case "Reverse":
                        string substring = data[1];
                        if (message.Contains(substring))
                        {
                            int startIndex = message.IndexOf(substring);
                            int endIndex = substring.Length;
                            message = message.Remove(startIndex, endIndex);
                            string newSubstring = string.Empty;
                            for (int i = substring.Length - 1; i >= 0; i--)
                            {
                                newSubstring += substring[i];
                            }
                            message = message.Insert(message.Length, newSubstring);
                        }
                        else
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        Console.WriteLine($"{message}");
                        break;
                    case "ChangeAll":
                        substring = data[1];
                        string replacement = data[2];
                        message = message.Replace(substring, replacement);
                        Console.WriteLine($"{message}");
                        break;
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
