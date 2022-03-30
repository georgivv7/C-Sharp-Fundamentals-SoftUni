using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var variable = Console.ReadLine();
            DataType(type, variable);
        }

        static void DataType(string type, string variable)
        {
            switch (type)
            {
                case"int":
                    int number1 = int.Parse(variable)*2;
                    Console.WriteLine(number1);
                    break;
                case "real":
                    double number2 = double.Parse(variable) * 1.5;
                    Console.WriteLine($"{number2:f2}");
                    break;
                case "string":
                    Console.WriteLine($"${variable}$");
                    break;
            }
        }
    }
}
