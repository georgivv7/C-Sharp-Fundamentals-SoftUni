using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            double expenses = 0;

            for (int currentGame = 1; currentGame <= lostGames; currentGame++)
            {
                if (currentGame%2==0)
                {
                    expenses += priceHeadset;
                }
                if (currentGame%3==0)
                {
                    expenses += priceMouse;
                }
                if (currentGame%6==0)
                {
                    expenses += priceKeyboard;
                }
                if (currentGame%12==0)
                {
                    expenses += priceDisplay;
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");

         
         

        }
    }
}
