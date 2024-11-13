namespace ChallengeApp
{
    public abstract class Person
    {

        public Person()
            :this("no name")
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Person(string name, string surname, string age, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        public string Sex { get; private set; }

    }
}
