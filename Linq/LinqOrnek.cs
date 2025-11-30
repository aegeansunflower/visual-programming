using System;
using System.Linq;

class LINQExample
{
    static void Main()
    {
        int[] values = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

        Console.Write("Orijinal dizi:");
        foreach (var element in values) Console.Write($" {element}");
        var filtered =
            from value in values
            where value > 4
            orderby value
            select value;

        Console.Write("\n4'ten büyük, sıralı sayılar:");
        foreach (var element in filtered) Console.Write($" {element}");
    }
}
