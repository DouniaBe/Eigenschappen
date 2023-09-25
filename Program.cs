// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Text.RegularExpressions;

class GetalString
{
    private string _getal;

    public string Getal
    {
        get { return _getal; }
        set
        {
            // Verwijder alle niet-getal-chars uit de string
            string cleanString = Regex.Replace(value, @"[^0-9\-]", "");

            // Als er geen getal overblijft, stel "0" in
            if (string.IsNullOrWhiteSpace(cleanString))
                _getal = "0";
            else
                _getal = cleanString;
        }
    }
}

class Program
{
    static void Main()
    {
        GetalString testje = new GetalString();

        testje.Getal = "a-53en nog 2iets5";

        Console.WriteLine("Invoer: \"a-53en nog 2iets5\"");
        Console.WriteLine("Getal: " + testje.Getal);

        // Andere tests
        testje.Getal = "12345";
        Console.WriteLine("\nInvoer: \"12345\"");
        Console.WriteLine("Getal: " + testje.Getal);

        testje.Getal = "-42abc";
        Console.WriteLine("\nInvoer: \"-42abc\"");
        Console.WriteLine("Getal: " + testje.Getal);

        testje.Getal = "abc";
        Console.WriteLine("\nInvoer: \"abc\"");
        Console.WriteLine("Getal: " + testje.Getal);

        Console.ReadKey();
    }
}
