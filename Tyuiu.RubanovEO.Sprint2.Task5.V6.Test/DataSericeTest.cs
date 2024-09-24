
using Tyuiu.RubanovEO.Sprint2.Task5.V6.Lib;

namespace Tyuiu.RubanovEO.Sprint2.Task5.V6.Test
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
            Assert.That(ds.FindCardNameAndValue(1,1), Is.EqualTo("Единица пики"));
        }
    }
}