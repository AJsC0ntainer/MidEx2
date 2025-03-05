using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidEx2
{
    internal class Program
    {
        public double amountToConvert = 0;
        private static double ammountToConvert;
        const double UtoE = 0.95;
        const double UtoJ = 25;
        const double EtoJ = 26;

        static void USDtoEUR(double amountToConvert)
        {
            double convertedAmount = amountToConvert * UtoE;
            Console.WriteLine($"The Converted amount is: {convertedAmount}");
        }
        static void USDtoJPY(double amountToConvert)
        {
            double convertedAmount = amountToConvert * UtoJ;
            Console.WriteLine($"The Converted amount is: {convertedAmount}");
        }
        static void EURtoJPY(double amountToConvert)
        {
            double convertedAmount = amountToConvert * EtoJ;
            Console.WriteLine($"The Converted amount is: {convertedAmount}");
        }
        static void JPYtoUSD(double ammountToConvert) 
        {
            double convertedAmount = ammountToConvert / UtoJ;
            Console.WriteLine($"The Converted amount is: {convertedAmount}");
        }
        static void JPYtoEUR(double ammountToConvert) 
        { 
            double convertedAmount = ammountToConvert / EtoJ;
            Console.WriteLine($"The Converted amount is: {convertedAmount}");
        }

        static void Main(string[] args)
        {
            double amountToConvert = 0;
            string fromCurrency = "";
            string toCurrency = "";


            Console.WriteLine("** WELCOME TO THE CURRENCY EXCHANGE APP **");
            Console.Write("Please enter the amount to convert: ");
            amountToConvert = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select the source currency:\n1. USD\n2. EUR\n3. JPY");
            Console.Write("Make a choice: ");
            fromCurrency = Console.ReadLine();

            Console.WriteLine("Please select the target currency:\n1. USD\n2. EUR\n3. JPY");
            Console.Write("Make a choice: ");
            toCurrency = Console.ReadLine();

            if (fromCurrency == "1" && toCurrency == "2")
            {
                USDtoEUR(amountToConvert);
            }
            else if (fromCurrency == "1" && toCurrency == "3")
            {
                USDtoJPY(amountToConvert);
            }
            else if (fromCurrency == "2" && toCurrency == "3")
            {
                EURtoJPY(amountToConvert);
            }
            else if (fromCurrency == "3" && toCurrency == "1") 
            { 
                JPYtoUSD(amountToConvert);
            }
            else if (fromCurrency == "3" && toCurrency == "2")
            {
                JPYtoEUR(amountToConvert);
            }
            else
            {
                Console.WriteLine("Invalid currency selection.");
            }
        }
        //Pushed to MidEx2 Repo
    }
}
