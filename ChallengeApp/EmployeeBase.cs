namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Surname { get; private set; }
        public string Name { get; private set; }

        public virtual void SayHello()
        {
            Console.WriteLine($"I am {Name} {Surname}");
        }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}
