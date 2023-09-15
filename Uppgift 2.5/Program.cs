using System;

namespace Uppgift2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en beräkning som innehåller två decimaltal och ett gångertecken imellan");
            string beräkning = Console.ReadLine();
            int gångerindex = beräkning.IndexOf("*");
            string decimal1text = beräkning[..gångerindex];
            string decimal2text = beräkning[(gångerindex + 1)..];
            float decimal1 = float.Parse(decimal1text);
            float decimal2 = float.Parse(decimal2text);
            float svar = decimal1 * decimal2;
            Console.WriteLine("Svaret är " + svar);
        }
    }
}