namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public EmployeeInFile(string name)
            : this(name, "no surname")
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello!");
            base.SayHello();
        }

        public override void AddGrade(float grade)
        {
            
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Initial value exceeds intended scope");
            }
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Unable to convert string to float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int lineCount = 0;
            if (File.Exists(fileName)) 
                foreach(var gradePerLine in File.ReadLines(fileName)) 
                {
                    var number = float.Parse(gradePerLine);

                    if (number >= 0)
                    {
                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        statistics.Average += number;
                        lineCount++;
                    }
                }
            statistics.Average /= lineCount;
            switch (statistics.Average)
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
        public void RemoveGrades()
        {
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, string.Empty);
            }
        }
    }
}
