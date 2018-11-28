using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calc
{
    class MyMathTest
    {
        [TestFixture]
        class Tests_Add
        {
            [TestCase]

            public void TestAddPositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(30, math.Add(10, 20));
 
            }

            [TestCase]

            public void TestAddNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(45, math.Add(10, 20));

            }
        }
        [TestFixture]
        class Tests_Sub
        {
            [TestCase]

            public void TestSubPositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(10, math.Sub(20, 10));

            }

            [TestCase]

            public void TestSubNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(5, math.Sub(20, 10));

            }
        }
        [TestFixture]
        class Tests_Multiple
        {
            [TestCase]

            public void TestMultiplePositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(200, math.Multiple(20, 10));

            }

            [TestCase]

            public void TestMultipleNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(150, math.Sub(20, 10));

            }
        }
        [TestFixture]
        class Tests_Divide
        {
            [TestCase]

            public void TestDividePositive()
            {
                MyMath math = new MyMath();
                Assert.LessOrEqual(math.Divide(20,10),3);

            }

            [TestCase]

            public void TestDivideNegative()
            {
                MyMath math = new MyMath();
                Assert.LessOrEqual(math.Divide(20, 10),1);

            }
        }
    }
}
