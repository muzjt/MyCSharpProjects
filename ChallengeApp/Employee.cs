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
            if (grade >= 0 && grade <= 100)
            {
                float intToFloatGrade = (float)grade;
                this.grades.Add(intToFloatGrade);
                Console.WriteLine($"Converted int({grade}) to float({intToFloatGrade}) and added to the list");
            }
            else
            {
                Console.WriteLine("Initial int exceeds intended scope");
            }

        }

        public void AddGrade(string grade) 
        {
            if (float.TryParse(grade, out float result))
            {
                if (result >= 0 && result <= 100)
                {
                    this.grades.Add(result);
                    Console.WriteLine($"Converted string({grade}) to float({result}) and added to the list");
                }
                else
                {
                    Console.WriteLine("Initial string exceeds intended scope");
                }
            }
            else 
            {
                Console.WriteLine("Unable to convert string to float");
            }
        }

        public void AddGrade(double grade)
        {
            if(grade >= 0 && grade <= 100) 
            { 
                float result = (float)grade;
                this.AddGrade(result);
                Console.WriteLine($"Converted double({grade}) to float({result}) and added to the list");
            } else 
            { 
                Console.WriteLine("Initial double exceeds intended scope");
            }
        }

        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.AddGrade(result);
                Console.WriteLine($"Converted long({grade}) to float({result}) and added to the list");
            }
            else
            {
                Console.WriteLine("Initial long exceeds intended scope");
            }
        }

        public void AddGrade(decimal grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.AddGrade(result);
                Console.WriteLine($"Converted decimal({grade}) to float({result}) and added to the list");
            }
            else
            {
                Console.WriteLine("Initial decimal exceeds intended scope");
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                Console.WriteLine($"Added float ({grade}) value to the list (without conversion)");
            }
            else
            {
                Console.WriteLine("Initial float exceeds intended scope");
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

