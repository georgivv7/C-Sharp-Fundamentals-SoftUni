using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string digit = "";
            for (int i = 1; i <= num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 2:
                        digit += "a";
                        break;
                    case 22:
                        digit += "b";
                        break;
                    case 222:
                        digit += "c";
                        break;
                    case 3:
                        digit += "d";
                        break;
                    case 33:
                        digit += "e";
                        break;
                    case 333:
                        digit += "f";
                        break;
                    case 4:
                        digit += "g";
                        break;
                    case 44:
                        digit += "h";
                        break;
                    case 444:
                        digit += "i";
                        break;
                    case 5:
                        digit += "j";
                        break;
                    case 55:
                        digit += "k";
                        break;
                    case 555:
                        digit += "l";
                        break;
                    case 6:
                        digit += "m";
                        break;
                    case 66:
                        digit += "n";
                        break;
                    case 666:
                        digit += "o";
                        break;
                    case 7:
                        digit += "p";
                        break;
                    case 77:
                        digit += "q";
                        break;
                    case 777:
                        digit += "r";
                        break;
                    case 7777:
                        digit += "s";
                        break;
                    case 8:
                        digit += "t";
                        break;
                    case 88:
                        digit += "u";
                        break;
                    case 888:
                        digit += "v";
                        break;
                    case 9:
                        digit += "w";
                        break;
                    case 99:
                        digit += "x";
                        break;
                    case 999:
                        digit += "y";
                        break;
                    case 9999:
                        digit += "z";
                        break;
                    case 0:
                        digit += " ";
                        break;

                }              
            }
            Console.Write(digit);
        }
    }
}
