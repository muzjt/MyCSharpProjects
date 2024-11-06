namespace ChallengeApp.Tests
{
    public class EmployeesTests
    {
        [Test]
        public void CheckIfMinGradeDiffersFromMaxGrade()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            Random random = new Random();
            float randomMin = 1.0f;
            float randomMax = 10.0f;
            // act
            for (int i = 0; i < 5; i++)
            {
                float randomRange = (float)(random.NextDouble() * (randomMax - randomMin) + randomMin);
                employee.AddGrade(randomRange);
            }
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreNotEqual(statistics.Min, statistics.Max);
        }

        [Test]
        public void CheckIfMinGradeIsSmallerThanMaxGrade()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            Random random = new Random();
            float randomMin = 1.0f;
            float randomMax = 10.0f;
            // act
            for (int i = 0; i < 5; i++)
            {
                float randomRange = (float)(random.NextDouble() * (randomMax - randomMin) + randomMin);
                employee.AddGrade(randomRange);
            }
            var statistics = employee.GetStatistics();

            // assert
            Assert.IsTrue(statistics.Min<statistics.Max);
        }

        [Test]
        public void CheckIfMaxGradeIsBiggerThanMinGrade()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            Random random = new Random();
            float randomMin = 1.0f;
            float randomMax = 10.0f;
            // act
            for (int i = 0; i < 5; i++)
            {
                float randomRange = (float)(random.NextDouble() * (randomMax - randomMin) + randomMin);
                employee.AddGrade(randomRange);
            }
            var statistics = employee.GetStatistics();

            // assert
            Assert.IsTrue(statistics.Max > statistics.Min);
        }

        [Test]
        public void CheckIfAverageGradeIsReallyAverage()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            Random random = new Random();
            float randomMin = 1.0f;
            float randomMax = 10.0f;
            int numberOfGrades = 0;
            // act
            for (int i = 0; i < 5; i++)
            {
                numberOfGrades++;
                float randomRange = (float)(random.NextDouble() * (randomMax - randomMin) + randomMin);
                employee.AddGrade(randomRange);
            }
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(statistics.Average, employee.GradesSummary / numberOfGrades);
        }

    }
}