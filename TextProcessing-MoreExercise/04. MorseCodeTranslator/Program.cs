using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> morseCodes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < morseCodes.Count; i++)
            {
                if (morseCodes[i] == "|")
                {
                    string oldChar = "|";
                    string newChar = " ";
                    morseCodes[i] = morseCodes[i].Replace(oldChar, newChar);
                }
            }

            for (int i = 0; i < morseCodes.Count; i++)
            {
                switch (morseCodes[i])
                {
                    case ".-":
                        decoded.Append('A');
                        break;
                    case "-...":
                        decoded.Append('B');
                        break;
                    case "-.-.":
                        decoded.Append('C');
                        break;
                    case "-..":
                        decoded.Append('D');
                        break;
                    case ".":
                        decoded.Append('E');
                        break;
                    case "..-.":
                        decoded.Append('F');
                        break;
                    case "--.":
                        decoded.Append('G');
                        break;
                    case "....":
                        decoded.Append('H');
                        break;
                    case "..":
                        decoded.Append('I');
                        break;
                    case ".---":
                        decoded.Append('J');
                        break;
                    case "-.-":
                        decoded.Append('K');
                        break;
                    case ".-..":
                        decoded.Append('L');
                        break;
                    case "--":
                        decoded.Append('M');
                        break;
                    case "-.":
                        decoded.Append('N');
                        break;
                    case "---":
                        decoded.Append('O');
                        break;
                    case ".--.":
                        decoded.Append('P');
                        break;
                    case "--.-":
                        decoded.Append('Q');
                        break;
                    case ".-.":
                        decoded.Append('R');
                        break;
                    case "...":
                        decoded.Append('S');
                        break;
                    case "-":
                        decoded.Append('T');
                        break;
                    case "..-":
                        decoded.Append('U');
                        break;
                    case "...-":
                        decoded.Append('V');
                        break;
                    case ".--":
                        decoded.Append('W');
                        break;
                    case "-..-":
                        decoded.Append('X');
                        break;
                    case "-.--":
                        decoded.Append('Y');
                        break;
                    case "--..":
                        decoded.Append('Z');
                        break;
                    case ".-.-.-":
                        decoded.Append('.');
                        break;
                    case "--..--":
                        decoded.Append(',');
                        break;
                    case "---...":
                        decoded.Append(':');
                        break;
                    case "..--...":
                        decoded.Append('?');
                        break;
                    case ".----.":
                        decoded.Append("'");
                        break;
                    case "-....-":
                        decoded.Append('-');
                        break;
                    case "-..-.":
                        decoded.Append('/');
                        break;
                    case "-.--.":
                        decoded.Append('(');
                        break;
                    case "-.--.-":
                        decoded.Append(')');
                        break;
                    case ".-..-.":
                        decoded.Append('"');
                        break;
                    case ".-...":
                        decoded.Append('&');
                        break;
                    case "-.-.--":
                        decoded.Append('!');
                        break;
                    case ".--.-.":
                        decoded.Append('@');
                        break;
                    case "-...-":
                        decoded.Append('=');
                        break;
                    case "-----":
                        decoded.Append('%');
                        break;
                    case ".-.-.":
                        decoded.Append('+');
                        break;
                    case " ":
                        decoded.Append(' ');
                        break;
                }
            }

            Console.WriteLine(decoded);
        }
    }
}
