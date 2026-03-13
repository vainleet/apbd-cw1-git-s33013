Console.WriteLine("Statistics Calculator");
<<<<<<< HEAD
Console.WriteLine("Please enter numbers:");
=======
Console.WriteLine("Enter numbers:");
>>>>>>> feature-conflict

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
Console.WriteLine("Max: " + StatisticsHelper.CalculateMax(numbers));
Console.WriteLine("Min: " + StatisticsHelper.CalculateMin(numbers));