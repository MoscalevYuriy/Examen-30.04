using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random rnd = new Random();
            int[,] array = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    array[i, y] = rnd.Next(-10, 10);
                }
            }
        }

    }
}
