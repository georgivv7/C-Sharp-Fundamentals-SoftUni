using System;

namespace _01._ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                var data = input.Split(">>>");
                string command = data[0];
                switch (command)
                {
                    case "Contains":
                        string substring = data[1];
                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string type = data[1];
                        int startIndex = int.Parse(data[2]);
                        int endIndex = int.Parse(data[3]);
                        if (type == "Upper")
                        {
                            string oldSubstring = activationKey.Substring(startIndex, endIndex - startIndex);
                            substring = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                            activationKey = activationKey.Replace(oldSubstring, substring);
                        }
                        else if (type == "Lower")
                        {
                            string oldSubstring = activationKey.Substring(startIndex, endIndex - startIndex);
                            substring = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                            activationKey = activationKey.Replace(oldSubstring, substring);
                        }
                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(data[1]);
                        endIndex = int.Parse(data[2]);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
