using Day6;
using System.Reflection.Metadata;

namespace Day7
{
    public class Tests
    {
        [Test]
        public void CheckIfPointsAddCorrectly()
        {
            // arrange
            var employee = new Employee("Marcin", "Kowalski", "32");
            employee.AddPoints(1);
            employee.AddPoints(2);

            // act
            var score = employee.PointsSummary;

            // assert
            Assert.AreEqual(3, score);
        }

        [Test]
        public void CheckIfPointsAddAndRemoveCorrectly()
        {
            // arrange
            var employee = new Employee("Marcin", "Kowalski", "32");
            employee.AddPoints(1);
            employee.AddPoints(2);
            employee.AddPoints(-1);

            // act
            var score = employee.PointsSummary;

            // assert
            Assert.AreEqual(2, score);
        }

        [Test]
        public void CheckIfScoreEqualsZero()
        {
            // arrange
            var employee = new Employee("Marcin", "Kowalski", "32");
            employee.AddPoints(1);
            employee.AddPoints(2);
            employee.AddPoints(-3);

            // act
            var score = employee.PointsSummary;

            // assert
            Assert.AreEqual(0, score);
        }
    }
}