
using Tyuiu.RubanovEO.Sprint2.Task6.V7.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task6.V7.Test
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
            Assert.That(ds.FindMonthName(1990, 12), Is.EqualTo("Декабрь"));
        }
    }
}