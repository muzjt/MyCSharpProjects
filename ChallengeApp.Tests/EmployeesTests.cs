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
        public void CheckIfStatisticsMaxIsCorrectMaxGrade()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(5);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void CheckIfStatisticsMinIsCorrectMinGrade()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(5);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void CheckIfStatisticsAverageIsCorrectAverageGrade()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(5);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(3.67, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void CheckIfCharIsBeingAddedCorrectly()
        {
            // arrange
            var employee = new Employee("Krystyna", "Janowicz");
            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(240, employee.GradesSummary);

        }

    }
}