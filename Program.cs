Console.WriteLine("Enter numbers separated by space:");

var input = Console.ReadLine();

var numbers = input.Split(' ')
                   .Select(int.Parse)
                   .ToArray();

Console.WriteLine("Sum: " + StatisticsHelper.Sum(numbers));