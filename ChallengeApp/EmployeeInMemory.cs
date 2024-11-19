using System.IO.Enumeration;

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message);
        }

        private void WriteMessageInConsole2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        public EmployeeInMemory(string name)
            : this(name, "no surname")
        {
        }

        public override void SayHello()
        {
            Console.WriteLine("Hello!");
            base.SayHello();
        }

        private List<float> grades = new List<float>();

        public float GradesSummary
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
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

            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
