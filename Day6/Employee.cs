namespace Day6
{
    public class Employee
    {
        private List<int> points = new List<int>();
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        
        public int PointsSummary
        { 
            get
            {
                return this.points.Sum();
            }
        }
        public void AddPoints(int number) 
        {
            this.points.Add(number);
        }
    }
}
