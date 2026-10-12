using CalculorApp;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Add add = new Add();
            int a = 1;
            int b = 2;
            //act
            int result = add.AddNumbers(a, b);
            //assert 
            Assert.AreEqual(3, result);
        }
    }
    [TestClass]
    public sealed class Test2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Add add = new Add();
            int a = 1;
            int b = 2;
            //act
            int result = add.AddNumbers(a, b);
            //assert 
            Assert.AreNotEqual(4, result);
        }
    }
}
