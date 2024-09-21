
using Tyuiu.RubanovEO.Sprint2.Task4.V16.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task4.V16.Test
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
            Assert.That(ds.Calculate(2,4), Is.EqualTo(1.129));
        }

        [Test]
        public void Test2()
        {
            DataService ds = new DataService();
            Assert.That(ds.Calculate(4, 2), Is.EqualTo(1.938));
        }
    }
}