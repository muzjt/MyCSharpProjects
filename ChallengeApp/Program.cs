using ChallengeApp;

Employee employee1 = new Employee("Ola", "Nowak", "45");
Employee employee2 = new Employee("Urszula", "Kowalska", "38");
Employee employee3 = new Employee("Piotr", "Bąk", "42");

List<Employee> employees = new List<Employee> { employee1, employee2, employee3 };
Random random = new Random();
foreach (Employee employee in employees)
{
    for (int i = 0; i < 5; i++)
    {
        int randomPoints = random.Next(1, 11);
        employee.AddPoints(randomPoints);
    }
}
Employee topEmployee = employees.OrderByDescending(e => e.PointsSummary).FirstOrDefault();
Console.WriteLine($"Details of the employee with the highest number of points: {topEmployee.Name} {topEmployee.Surname}, {topEmployee.Age} years old, points: {topEmployee.PointsSummary}");
