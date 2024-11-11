using ChallengeApp;

Console.WriteLine("Welcome to employees evaluation program");
Console.WriteLine("=======================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Add employee grade or press 'q' to view grades: ");
    var input = Console.ReadLine();
    char inputC = input[0];
    if (input == "q")
    {
        break;
    } else if (input.Length == 1 && !char.IsDigit(inputC))
    {
        employee.AddGrade(inputC);
    } else 
    {
        employee.AddGrade(input);
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");




