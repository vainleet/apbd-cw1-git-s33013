Console.WriteLine("Statistics Calculator");
Console.WriteLine("Enter numbers separated by space:");

var input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Input cannot be empty");
    return;
}

var numbers = input.Split(' ')
                   .Select(int.Parse)
                   .ToArray();

Console.WriteLine("Sum: " + StatisticsHelper.Sum(numbers));
Console.WriteLine("Avg: " + StatisticsHelper.CalculateAverage(numbers));
Console.WriteLine("Avg: " + StatisticsHelper.CalculateMax(numbers));