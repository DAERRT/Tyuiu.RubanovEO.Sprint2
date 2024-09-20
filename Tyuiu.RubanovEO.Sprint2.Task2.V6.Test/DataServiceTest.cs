
using Tyuiu.RubanovEO.Sprint2.Task2.V6.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task2.V6.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.That(ds.CheckDotInShadedArea(3,3));
        }
    }
}