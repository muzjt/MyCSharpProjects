using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

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
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
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
            if (File.Exists(fileName))
                foreach (var gradePerLine in File.ReadLines(fileName))
                {
                    if (float.TryParse(gradePerLine, out float result)) 
                    {
                        statistics.AddGrade(result);
                    }
                }
            return statistics;
        }
    }
}
