namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        bool IsSimple(int x)
        {
            bool simple = true;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    simple = false;
                    break;
                }
            }
            return simple;
        }
        //<summary>
        //Позитивный тест, ожидается простое число
        //</summary>
        [TestMethod]
        public void Simple17()
        {
            Assert.IsTrue(IsSimple(17));
        }
        //<summary>
        //Негативный тест, ожидается непростое число
        //<summary>
        [TestMethod]
        public void Simple72()
        {
            Assert.IsTrue(IsSimple(72));
        }
        //<summary>
        //Негативный тест, ожидается непростое число
        //<summary>
        [TestMethod]
        public void Simple1()
        {
            Assert.IsTrue(IsSimple(1));
        }
        //<summary>
        //Негативный тест, ожидается непростое число
        //<summary>
        [TestMethod]
        public void Simple0()
        {
            Assert.IsTrue(IsSimple(0));
        }
        //<summary>
        //Негативный тест, ожидается непростое число, меньше нуля
        //<summary>
        [TestMethod]
        public void SimpleMinus5()
        {
            Assert.IsTrue(IsSimple(-5));
        }
    }
}
