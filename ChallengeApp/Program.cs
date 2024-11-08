using ChallengeApp;

var employee = new Employee("Antoni", "Nowak");
employee.AddGrade(10);
employee.AddGrade(2.2f);
employee.AddGrade("101");
employee.AddGrade(99.99);
employee.AddGrade(87L);
employee.AddGrade(50.19m);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Number of grades inside list: {employee.GradesCount}");

