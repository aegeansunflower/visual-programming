using System;

public class Time2
{
    private int hour;
    private int minute;
    private int second;
    public Time2() : this(0, 0, 0) { }
    public Time2(int hour, int minute, int second)
    {
        SetTime(hour, minute, second);
    }

    public void SetTime(int hour, int minute, int second)
    {
        if ((hour < 0 || hour > 23) || (minute < 0 || minute > 59) || (second < 0 || second > 59))
        {
            throw new ArgumentOutOfRangeException("Zaman değerleri geçersiz.");
        }
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public string ToUniversalString() => $"{hour:D2}:{minute:D2}:{second:D2}";

    public override string ToString() =>
        $"{((hour == 0 || hour == 12) ? 12 : hour % 12)}:{minute:D2}:{second:D2} {(hour < 12 ? "AM" : "PM")}";
}
