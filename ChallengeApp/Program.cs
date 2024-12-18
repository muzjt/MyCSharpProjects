﻿using ChallengeApp;

Console.WriteLine("Welcome to employees evaluation program");
Console.WriteLine("=======================================");
Console.WriteLine();

var employee = new EmployeeInFile("Ola", "Nowak");
employee.GradeAdded += EmployeeGradeAdded;


void EmployeeGradeAdded(object sender, EventArgs args) 
{
    Console.WriteLine("Added new grade");
}

while (true)
{
    Console.WriteLine("Add employee grade or press 'q' to view grades: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        if (input.Length == 1 && !char.IsDigit(input[0]))
        {
            employee.AddGrade(input[0]);
        }
        else
        {
            employee.AddGrade(input);
        }
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}"); 
Console.WriteLine($"MIN: {statistics.Min:N2}");
Console.WriteLine($"MAX: {statistics.Max:N2}");




