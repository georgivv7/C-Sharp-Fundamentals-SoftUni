using System;

namespace _01._PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = string.Empty;
            
            while ((command = Console.ReadLine()) != "Done")
            {
                var data = command.Split();
                string commands = data[0];

                switch (commands)
                {
                    case "TakeOdd":
                        string newPassword = string.Empty;
                        for (int i = 1; i <= password.Length - 1; i++)
                        {
                            if (i % 2 != 0)
                            {
                                newPassword += password[i];
                            }
                        }
                        password = newPassword;
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(data[1]);
                        int length = int.Parse(data[2]);
                        password = password.Remove(index, length);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = data[1];
                        string replacement = data[2];
                        if (password.Contains(substring))
                        {
                            password = password.Replace(substring, replacement);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
