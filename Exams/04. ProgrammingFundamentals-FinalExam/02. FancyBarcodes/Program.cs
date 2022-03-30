using System;
using System.Text.RegularExpressions;

namespace _02._FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@([#]+)(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@[#]+";
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match validBarcode = Regex.Match(barcode, pattern);
                if (validBarcode.Success)
                {
                    string valid = validBarcode.Groups["barcode"].Value;
                    string productGroup = string.Empty;
                    int counter = 0;
                    for (int j = 0; j < valid.Length; j++)
                    {
                        if (char.IsDigit(valid[j]))
                        {
                            counter++;
                            productGroup += valid[j];
                        }
                    }
                    if (counter > 0)
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
