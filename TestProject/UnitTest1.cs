using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int a = 2;
            int b = 2;
            float expected = 1;

            //act
            // тут мы должны создать экземпл€р класса, чтобы протестировать его
            Number MyNumber = new Number();
            float actual = MyNumber.Div(a, b);

            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
