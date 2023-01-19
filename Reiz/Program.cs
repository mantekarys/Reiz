Console.WriteLine(Clock.ClockDegrees(4,90));
Console.WriteLine(Clock.ClockDegrees(2, 30));
Console.WriteLine(Clock.ClockDegrees(6, 10));
Console.WriteLine(Clock.ClockDegrees(30, 10));

public class Clock
{
    public static int ClockDegrees(int hours, int minutes)
    {
        Console.WriteLine($"{hours}:{minutes}");
        if (minutes > 60)
        {
            hours += minutes / 60;
        }

        int hDegrees=hours * 30 % 360;
        int mDegrees = minutes * 6 % 360;

        int bigger;
        int smaller;

        if (mDegrees > hDegrees)
        {
            bigger = mDegrees;
            smaller = hDegrees;
        }
        else
        {
            bigger = hDegrees;
            smaller = mDegrees;
        }
        return bigger-smaller;
    }
}