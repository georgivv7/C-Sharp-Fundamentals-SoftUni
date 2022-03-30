using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = null;
            string input = Console.ReadLine();
            int counter = 0;
            for (int i = username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }
            while (true)
            {
                
                if (input!=password)
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
                
                else if(input==password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
               
                input = Console.ReadLine();

            }
            
        }
    }
}
