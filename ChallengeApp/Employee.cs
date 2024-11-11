using System;
using System.Diagnostics;

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

        public Employee()
        {
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

        public void AddGrade(char grade)
        {
            switch (grade) 
            { 
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong letter");
                    break;
            }
        }           

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}

 