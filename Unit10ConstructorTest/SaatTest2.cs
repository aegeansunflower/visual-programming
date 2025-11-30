using System;

class Time2Test
{
    static void Main()
    {
        var t1 = new Time2();             // 00:00:00
        var t2 = new Time2(2, 0, 0);      // 02:00:00
        var t3 = new Time2(21, 34, 0);    // 21:34:00

        Console.WriteLine($"t1: {t1.ToUniversalString()}");
        Console.WriteLine($"t2: {t2.ToUniversalString()}");
        Console.WriteLine($"t3 (Standart): {t3.ToString()}");
        Console.WriteLine($"t3 (Evrensel): {t3.ToUniversalString()}");
    }
}
