using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        int iSodasAdj = 0;
        int iChipsAdj = 0;
        int iCandyAdj = 0;
        bool bSodasRes = false;
        bool bChipsRes = false;
        bool bCandyRes = false;
        Console.Write("How many sodas have been sold today? 100 in stock: ");
        int iSodas = int.Parse(Console.ReadLine());
        if (iSodas > 100)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            iSodasAdj = 100 - iSodas;
            Console.WriteLine("There are " + iSodasAdj + " Sodas left.");
            if (iSodasAdj <= 40)
            {
                bSodasRes = true;
            }
        }

        Console.Write("How many Chips have been sold today? 40 are in stock: ");
        int iChips = int.Parse(Console.ReadLine());
        if (iChips > 40)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            iChipsAdj = 40 - iChips;
            Console.WriteLine("There are " + iChipsAdj + " Chips left.");
            if (iChipsAdj <= 20)
            {
                bChipsRes = true;
            }
        }

        Console.Write("How many Candy have been sold today? 60 are in stock: ");
        int iCandy = int.Parse(Console.ReadLine());
        if (iCandy > 60)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
        }
        else
        {
            iCandyAdj = 60 - iCandy;
            Console.WriteLine("There are " + iCandyAdj + " Candies left.");
            if (iCandyAdj <= 40)
            {
                bCandyRes = true;
            }
        }
        
        if (bSodasRes || bChipsRes || bCandyRes)
        {
            Console.WriteLine("Thank you for filling out the values.Here’s what needs to be restocked:");            if (bSodasRes)
            {
                Console.WriteLine("Sodas need to be restocked");
            }            if (bChipsRes)
            {
                Console.WriteLine("Chips need to be restocked");
            }            if (bCandyRes)
            {
                Console.WriteLine("Candies need to be restocked");
            }
        }
        else
        {
            Console.WriteLine("Nothing needs to be restocked.");
        }
    }
}

