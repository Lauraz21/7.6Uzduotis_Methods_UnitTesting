using _7._6Uzduotis_Methods_UnitTesting;
namespace Test7._6Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEvenNumber()
        {
            int userInput = 12;
            bool actual = Program.IsNumberEven(userInput);
            Assert.IsTrue(actual);
        }
    }
}