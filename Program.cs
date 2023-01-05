using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(20));
            Console.WriteLine(DateTime.Now.AddMilliSeconds(50));

            //DateTime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); //24 
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday
             
            Console.WriteLine(DateTime.Now.ToString("MM")); //04 
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April
             
            Console.WriteLine(DateTime.Now.ToString("yy")); //23
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2023
          

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); //25
            Console.WriteLine(Math.Sin(15)); 
            Console.WriteLine(Math.Cos(15)); 
            Console.WriteLine(Math.Tan(15)); 

            Console.WriteLine(Math.Ceiling(15.3)); 
            Console.WriteLine(Math.Round(15.3)); 
            Console.WriteLine(Math.Floor(5.2)); 

            Console.WriteLine(Math.Max(2.2));
            Console.WriteLine(Math.Min(2.2));

            Console.WriteLine(Math.Pow(5.2)); //5 üzeri 2 yi verir
            Console.WriteLine(Math.Sqrt(9)); // Karekök alır
            Console.WriteLine(Math.Log(9));  //9 un e karşılığındaki logaritmik karşılığını verir.
            Console.WriteLine(Math.Exp(3));  // e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı

        }
    }
}
