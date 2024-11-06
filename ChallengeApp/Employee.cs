namespace ChallengeApp
{
    public class Employee
    {
        private List<int> points = new List<int>();
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee(string name)
        {
            this.Name = name;
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
        public float GradesSummary
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public void AddPoints(int number)
        {
            this.points.Add(number);
        }
        public void AddGrade(float grade) 
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}

