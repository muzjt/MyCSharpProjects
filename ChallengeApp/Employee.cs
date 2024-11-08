using System;

namespace ChallengeApp
{
    public class Employee
    {
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
        public float GradesSummary
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public float GradesCount
        {
            get
            {
                return this.grades.Count;
            }
        }

        public void AddGrade(int grade)
        {
            
         float intToFloatGrade = (float)grade;
         this.AddGrade(intToFloatGrade);
        }

        public void AddGrade(string grade) 
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            } 
            else 
            {
                Console.WriteLine("Unable to convert string to float"); 
            }
        }

        public void AddGrade(double grade)
        {
                float result = (float)grade;
                this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
                float result = (float)grade;
                this.AddGrade(result);
        }

        public void AddGrade(decimal grade)
        {
                float result = (float)grade;
                this.AddGrade(result);
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                Console.WriteLine($"Added float ({grade}) value to the list");
            }
            else
            {
                Console.WriteLine("Initial value exceeds intended scope");
            }
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

