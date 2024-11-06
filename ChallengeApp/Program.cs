using ChallengeApp;

var employee = new Employee("Antoni", "Nowak");
Random random = new Random();
float randomMin = 1.0f;
float randomMax = 10.0f;
for (int i = 0; i < 5; i++) 
{
    float randomRange = (float)(random.NextDouble() * (randomMax - randomMin) + randomMin);
    employee.AddGrade(randomRange);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

