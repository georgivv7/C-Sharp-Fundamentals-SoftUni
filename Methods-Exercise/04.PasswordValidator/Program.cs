using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordChecker(password);
        }

        static void PasswordChecker(string password)
        {
            bool isInvalid = false;

            if (!(password.Length >= 6 && password.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isInvalid = true;
            }

            if (CheckLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isInvalid = true;
            }

            if (CheckDigits(password) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isInvalid = true;
            }

            if (isInvalid == false)
            {
                Console.WriteLine("Password is valid");
            }

        }

        static bool CheckLettersAndDigits(string password)
        {
            bool isInvalid = false;
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                if (!(currentChar >= 48 && currentChar <= 57 || currentChar >= 65 && currentChar <= 90 ||
                    currentChar >= 97 && currentChar <= 122))
                {
                    isInvalid = true;
                }
            }
            return isInvalid;
        }

        static int CheckDigits(string password)
        {
            int digitsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char digits = password[i];
                if (digits >= 48 && digits <= 57)
                {
                    digitsCounter++;
                }
            }
            return digitsCounter;

        }
    }
}