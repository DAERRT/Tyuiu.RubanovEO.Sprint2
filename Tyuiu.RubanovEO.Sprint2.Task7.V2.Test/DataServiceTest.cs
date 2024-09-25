
using Tyuiu.RubanovEO.Sprint2.Task7.V2.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task7.V2.Test
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
            Assert.That(ds.CheckDotInShadedArea(1,-0.5), Is.EqualTo(false));
        }

        [Test]
        public void Test2()
        {
            DataService ds = new DataService();
            Assert.That(ds.CheckDotInShadedArea(0.5,-0.5), Is.EqualTo(true));
        }
    }
}