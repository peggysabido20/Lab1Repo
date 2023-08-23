using System;

public class Program
{
    public static void Main()
    {
        Console.Write("How many sodas have been sold today? 100 in stock: ");
        int iSodas = int.Parse(Console.ReadLine());
        if (iSodas > 100)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            int iSodasAdj = 100 - iSodas;
            Console.WriteLine("There are " + iSodasAdj + " Sodas left.");
        }

        Console.Write("How many Chips have been sold today? 40 are in stock: ");
        int iChips = int.Parse(Console.ReadLine());
        if (iChips > 40)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            int iChipsAdj = 40 - iChips;
            Console.WriteLine("There are " + iChipsAdj + " Chips left.");
        }

        Console.Write("How many Candy have been sold today? 60 are in stock: ");
        int iCandy = int.Parse(Console.ReadLine());
        if (iCandy > 60)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            int iCandyAdj = 60 - iCandy;
            Console.WriteLine("There are " + iCandyAdj + " Candies left.");
        }
    }
}

