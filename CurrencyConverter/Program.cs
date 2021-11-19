using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double rubToUsd = 74.22, usdToRub = 71.22;
            double rubToEur = 83.96, eurToRub = 80.95;
            double usdToEur = 1.09, eurToUsd = 0.85;
            double rub, usd, eur;
            string userInput;
            float currencyCount;

            Console.WriteLine("Введите баланс рублей:");
            rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите баланс долларов:");
            usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите баланс евро:");
            eur = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Добро пожаловать в обменник. У нас вы можете обменять рубли, доллары и евро.");
            Console.WriteLine("Обменять рубли на доллары - rd, обменять доллары на рубли - dr");
            Console.WriteLine("Обменять рубли на евро - re, обменять евро на рубли - er");
            Console.WriteLine("Обменять доллары на евро - de, обменять евро на доллары - ed");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "rd":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во рублей");
                    }
                    break;
                case "dr":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во долларов");
                    }
                    break;
                case "re":
                    Console.WriteLine("Обмен рублей на евро");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        eur += currencyCount / rubToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во рублей");
                    }
                    break;
                case "er":
                    Console.WriteLine("Обмен евро на рубли");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount;
                        rub += currencyCount * eurToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во евро");
                    }
                    break;
                case "de":
                    Console.WriteLine("Обмен долларов на евро");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        eur += currencyCount * eurToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во евро");
                    }
                    break;
                case "ed":
                    Console.WriteLine("Обмен евро на доллары");
                    Console.WriteLine("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (eur >= currencyCount)
                    {
                        eur -= currencyCount;
                        usd += currencyCount * usdToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое кол-во евро");
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("Ваш баланс " + rub + " рублей, " + usd + " долларов и " + eur + " евро.");
            Console.ReadLine();
        }
    }
}
