using NUnit.Framework;

namespace FizzBuzzCS
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void CanInstantiateTest()
        {
            FizzBuzz game = new FizzBuzz();
            Assert.That(game, Is.Not.Null);
        }

        [Test]
        public void IsDivisibleByThreeTest()
        {
            FizzBuzz game = new FizzBuzz();
            bool isDivisibleByThree = game.IsFizzer(3);
            Assert.AreEqual(true, isDivisibleByThree);
        }

        [Test]
        public void ReturnFizzTest()
        {
            FizzBuzz game= new FizzBuzz();
            string returnGetNumberText = game.GetNumberText(6);
            Assert.AreEqual("FIZZ", returnGetNumberText);
        }

        [Test]
        public void IsDivisibleByFiveTest()
        {
            FizzBuzz game = new FizzBuzz();
            bool isDivisibleByFive = game.IsBuzzer(5);
            Assert.AreEqual(true, isDivisibleByFive);
        }

        [Test]
        public void ReturnBuzzTest()
        {
            FizzBuzz game = new FizzBuzz();
            string returnGetNumberText = game.GetNumberText(10);
            Assert.AreEqual("BUZZ", returnGetNumberText);
        }

        [Test]
        public void ReturnFizzBuzzTest()
        {
            FizzBuzz game = new FizzBuzz();
            string returnGetNumberText = game.GetNumberText(15);
            Assert.AreEqual("FIZZBUZZ", returnGetNumberText);
        }

        [Test]
        public void ReturnAllOtherValues()
        {
            FizzBuzz game = new FizzBuzz();
            string returnTextForNumber = game.GetNumberText(4);
            Assert.AreEqual("4", returnTextForNumber);
        }

        [Test]
        public void ReturnAllValueTest()
        {
            FizzBuzz game = new FizzBuzz();
            game.Process(200);
        }
    }
}