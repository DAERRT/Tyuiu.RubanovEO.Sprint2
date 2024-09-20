
using Tyuiu.RubanovEO.Sprint2.Task1.V3.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task1.V3.Test
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
            bool[] res = [true, false, false, false, false, false];
            Assert.That(ds.GetLogicOperations(185,316,134,134), Is.EqualTo(res));
        }
    }
}