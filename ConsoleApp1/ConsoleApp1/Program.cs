
using System;
class Converter{
    decimal usd, eur;
    public Converter(decimal usd, decimal eur)
    {
        this.usd = usd;
        this.eur = eur;
    }
    public decimal UsdtoUah(decimal n)
    {
        return n * usd;
    }
    public decimal EurtoUah(decimal n)
    {
        return n * eur;
    }
    public decimal UahtoUsd(decimal n)
    {
        return n / usd;
    }
    public decimal UahtoEur(decimal n)
    {
        return n / eur;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Курс долара:");
        decimal usd = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Курс євро:");
        decimal eur = Convert.ToDecimal(Console.ReadLine());
        Converter c = new Converter(usd, eur);
        while (true)
        {
            string s = Console.ReadLine();
            decimal d = Convert.ToDecimal(Console.ReadLine());
            if (s == "1")
            {
                Console.WriteLine(c.UahtoUsd(d));
            }
            else if (s == "2")
            {
                Console.WriteLine(c.UahtoEur(d));
            }
            else if (s == "3")
            {
                Console.WriteLine(c.UsdtoUah(d));
            }
            else if (s == "4")
            {
                Console.WriteLine(c.EurtoUah(d));
            }
            else
            {
                break;
            }
        }
    }
}
