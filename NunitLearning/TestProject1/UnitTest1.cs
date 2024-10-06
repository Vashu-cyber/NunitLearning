namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Browser Opened");
            Assert.True(true);
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test 1 Executed");
            Assert.Pass("Done");
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("Test 2 Executed");
            Assert.Pass("Done");
        }

        [TearDown]
        public void closeBrowser()
        {
            Console.WriteLine("Browser Closed");
        }
    }
}