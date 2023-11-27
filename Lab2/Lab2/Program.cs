using Lab2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Time t1 = new Time(9, 30, 15);
        Console.WriteLine("Время 1: " + t1);

        Time t2 = new Time(12,30,0);
        Console.WriteLine("Время 2: " + t2);

        Time t3 = new Time(16, 30, 15);
        Console.WriteLine("Время 3: " + t3);

        Time t4 = new Time(19, 0, 0);
        Console.WriteLine("Время 4: " + t4);

        Time t5 = new Time(26, 0, 0);
        Console.WriteLine("Время 5: " + t5);


        Time[] times = new Time[]
        {
            new Time(8, 30, 0),  // Утро
            new Time(12, 45, 0), // День
            new Time(19, 15, 0), // Вечер
            new Time(2, 0, 0)    // Ночь
        };

        // a) Время с заданным числом часов
        int targetHours = 12;
        Console.WriteLine($"Времена с {targetHours} часами:");
        foreach (var time in times)
        {
            if (time.Hours == targetHours)
            {
                Console.WriteLine($"{time.Hours}:{time.Minutes}:{time.Seconds}");
            }
        }

        // b) Группы времен: ночь, утро, день, вечер
        Console.WriteLine("\nВремена по группам:");
        foreach (var time in times)
        {
            if (time.Hours >= 0 && time.Hours < 6)
            {
                Console.WriteLine($"{time.Hours}:{time.Minutes}:{time.Seconds} - Ночь");
            }
            else if (time.Hours >= 6 && time.Hours < 12)
            {
                Console.WriteLine($"{time.Hours}:{time.Minutes}:{time.Seconds} - Утро");
            }
            else if (time.Hours >= 12 && time.Hours < 18)
            {
                Console.WriteLine($"{time.Hours}:{time.Minutes}:{time.Seconds} - День");
            }
            else
            {
                Console.WriteLine($"{time.Hours}:{time.Minutes}:{time.Seconds} - Вечер");
            }
        }

        var anonymous = new
        {
            Hours = "hours",
            Minutes = "minutes",
            Seconds = "seconds"
        };
    }
}
