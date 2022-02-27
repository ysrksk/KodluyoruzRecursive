using System;

namespace RecursiveMethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //rekürsive - öz yinelemeli
           // 3^4 = 3*3*3*3

           int result = 1;
           for (int i = 1; i < 5; i++)
           {
               result *=3;
               System.Console.WriteLine(result);
           }

           Islemler instance = new();
           System.Console.WriteLine(instance.Expo(3,4));


           //Extension Method
           string ifade = "Zikriye Ürkmez";
           bool sonuc = ifade.CheckSpaces();
           System.Console.WriteLine(sonuc);

           if (sonuc)
           {
               System.Console.WriteLine(ifade.RemoveWhiteSpaces());
           }
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us<2)
            {
                return sayi;
            }
            return Expo(sayi, us-1)* sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("",dizi);
    }
}
