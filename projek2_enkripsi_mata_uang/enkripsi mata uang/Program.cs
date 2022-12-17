using System;

namespace enkripsi_mata_uang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Abdul`s IDR to USD Converter. \nWhat currency do you have?1 for IDR, 2 for USD");
            var currencyFrom =(Currency)Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("How muct do you convert?");
            var amountToConfert=double.Parse(Console.ReadLine());
            var convertedAmount=CurrencyUtility.Convert(amountToConfert, currencyFrom);
            Console.WriteLine(convertedAmount);
        }
    }

    static class CurrencyUtility{
        public static double Convert(double amountValue, Currency currency){
            double returnAmount=0;
            if(currency == Currency.IDR){
                returnAmount= amountValue * 15361;
            }
            else if (currency == Currency.USD){
                returnAmount =amountValue / 15361;
            }
            return returnAmount;

        }
    }

    public enum Currency{
        USD=1,
        IDR
    }
}

