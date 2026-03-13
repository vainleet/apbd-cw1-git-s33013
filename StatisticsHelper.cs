
public static class StatisticsHelper
{
    public static int Sum(int[] values)
    {
        int sum = 0;

        foreach (var v in values)
        {
            sum += v;
        }

        return sum;
    }

    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
            return 0;

        return (double)Sum(values) / values.Length;
    }

    public static int CalculateMax(int[] values)
    {
        return values.Max();
    }
}

