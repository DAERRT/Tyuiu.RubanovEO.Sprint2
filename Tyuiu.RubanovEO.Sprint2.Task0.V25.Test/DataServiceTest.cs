
using Tyuiu.RubanovEO.Sprint2.Task0.V25.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task0.V25.Test
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
            bool[] res = [true, true, true, false, false, false];
            Assert.That(ds.GetCompareOperations(205,159), Is.EqualTo(res));
        }
    }
}