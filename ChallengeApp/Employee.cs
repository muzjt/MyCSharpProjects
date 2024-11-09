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

        //public Statistics GetStatistics() 
        //{
        //    var statistics = new Statistics();
        //    statistics.Average = 0;
        //    statistics.Max = float.MinValue;
        //    statistics.Min = float.MaxValue;

        //    foreach (var grade in this.grades)
        //    {
        //        if (grade >= 0)
        //        {
        //            statistics.Max = Math.Max(statistics.Max, grade);
        //            statistics.Min = Math.Min(statistics.Min, grade);
        //            statistics.Average += grade;
        //        }
        //    } 
        //    statistics.Average /= this.grades.Count;
        //    return statistics;
        //}
        public Statistics GetStatisticsWithForEach()
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
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                if (this.grades[i] >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                    statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                    statistics.Average += this.grades[i];
                }
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int index = 0;
            do
            { 
             statistics.Max = Math.Max(statistics.Max, this.grades[index]);
             statistics.Min = Math.Min(statistics.Min, this.grades[index]);
             statistics.Average += this.grades[index];
             index++;
            } while (index < this.grades.Count);
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int index = 0;
            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}

 