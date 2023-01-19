Console.WriteLine("First exercise");
Console.WriteLine(Clock.ClockDegrees(4,90));
Console.WriteLine(Clock.ClockDegrees(2, 30));
Console.WriteLine(Clock.ClockDegrees(6, 10));
Console.WriteLine(Clock.ClockDegrees(30, 10));

Console.WriteLine(new String('-',25));
Console.WriteLine("Second exercise");

// Making a structure like the example
Branch b1 = new Branch();
b1.Add();
Branch b2 = new Branch();
b2.Add(b1);
b2.Add();
Branch b3 = new Branch();
b3.Add();
Branch b4 = new Branch();
b4.Add(b3);
b4.Add(b2);
b4.Add();
Branch b5 = new Branch();
b5.Add();
Branch b6 = new Branch();
b6.Add(b5);
b6.Add(b4);

Console.WriteLine(b6.Depth(1));

for (int i = 0; i < 3; i++)
{
    b1.Add(new Branch());
}
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
public class Branch
{
    List<Branch> branches= new List<Branch>();

    public void Add(Branch branch) 
    { 
        branches.Add(branch); 
    }
    public void Add()
    {
        branches.Add(new Branch());
    }

    public int Depth(int currentDepth)
    {
        if (branches.Count == 0) return currentDepth;
        int max = currentDepth;
        foreach (var branch in branches)
        {
            int depth = branch.Depth(currentDepth+1);
            if(depth > max) max = depth;
        }
        return max;
    }
}