namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void AreTwoIntegersNotEqual()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;

            // act

            // assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void AreTwoFloatsEqual()
        {
            // arrange
            float number1 = 1.1f;
            float number2 = 1.1f;

            // assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void IsFloatEqualToInteger()
        {
            // arrange
            float number1 = 1.0f;
            int number2 = 1;

            // assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void AreTwoObjectsNotEqual()
        {
            // arrange
            var employee1 = GetEmployee("Ola");
            var employee2 = GetEmployee("Ola");

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void AreTwoStringsEqual()
        {
            // arrange
            var employee1 = GetEmployee("Ola");
            var employee2 = GetEmployee("Ola");

            // assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
