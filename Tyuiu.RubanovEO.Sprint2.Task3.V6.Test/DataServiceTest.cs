
using Tyuiu.RubanovEO.Sprint2.Task3.V6.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task3.V6.Test
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
            Assert.That(ds.Calculate(0), Is.EqualTo(0.75));
        }
    }
}