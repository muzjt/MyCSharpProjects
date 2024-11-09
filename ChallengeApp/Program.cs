using ChallengeApp;

var employee = new Employee("Antoni", "Nowak");
employee.AddGrade(10);
employee.AddGrade(2.2f);
employee.AddGrade("101");
employee.AddGrade(99.99);
employee.AddGrade(87L);
employee.AddGrade(50.19m);
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine($"Using GetStatisticsWithForEach method. Average: {statistics1.Average:N2}, Min: {statistics1.Min}, Max: {statistics1.Min}");
Console.WriteLine($"Using GetStatisticsWithFor method. Average: {statistics2.Average:N2}, Min: {statistics2.Min}, Max: {statistics2.Min}");
Console.WriteLine($"Using GetStatisticsWithDoWhile method. Average: {statistics3.Average:N2}, Min: {statistics3.Min}, Max: {statistics3.Min}");
Console.WriteLine($"Using GetStatisticsWithWhile method. Average: {statistics4.Average:N2}, Min: {statistics4.Min}, Max: {statistics4.Min}");

