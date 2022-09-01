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
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(20));
Console.WriteLine(DateTime.Now.AddMonths(3));
Console.WriteLine(DateTime.Now.AddYears(22));
Console.WriteLine(DateTime.Now.AddMilliseconds(22));

// Datetime Format
Console.WriteLine(DateTime.Now.ToString("dd"));
Console.WriteLine(DateTime.Now.ToString("ddd"));
Console.WriteLine(DateTime.Now.ToString("dddd"));

Console.WriteLine(DateTime.Now.ToString("MM"));
Console.WriteLine(DateTime.Now.ToString("MMM"));
Console.WriteLine(DateTime.Now.ToString("MMMM"));

Console.WriteLine(DateTime.Now.ToString("yy"));
Console.WriteLine(DateTime.Now.ToString("yyyy"));

// Math Kürüphanesi
Console.WriteLine(Math.Abs(-25)); //Mutlak değer
Console.WriteLine(Math.Sin(45)); // sinus değeri
Console.WriteLine(Math.Cos(45)); // sinus değeri
Console.WriteLine(Math.Tan(45)); // sinus değeri

Console.WriteLine(Math.Ceiling(22.3)); // yukarı yuvarlar
Console.WriteLine(Math.Round(22.5)); // en yakın değere yuvarlar
Console.WriteLine(Math.Floor(22.3)); // aşağı yuvarlar

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(3,4)); //3^4 ü verir
Console.WriteLine(Math.Sqrt(9)); // Karekök alır
Console.WriteLine(Math.Log(9)); // logaritma alır
Console.WriteLine(Math.Exp(3)); //e üzeri 3 ü verir.
Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı
