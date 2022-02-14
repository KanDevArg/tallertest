using System;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SumInputsSameLength()
        {
            var total = csharptest.Program.sumN1AndReversedN2(1000, 2000);
            Assert.True(total == 1002);
        }
        
        [Test]
        public void SumInputsDifferentLength()
        {
            var total = csharptest.Program.sumN1AndReversedN2(1000, 20);
            Assert.True(total == 1002);
        }
        
        [Test]
        public void SumInputsDifferentLength_1()
        {
            var total = csharptest.Program.sumN1AndReversedN2(123456, 123456);
            Assert.True(total == 777777);
        }
        
        [Test]
        public void SumInputsDifferentLength_2()
        {
            var total = csharptest.Program.sumN1AndReversedN2(123456, 123);
            Console.WriteLine(total);
            Assert.True(total == 123777);
        }
        
        [Test]
        public void SumInputsDifferentLength_3()
        {
            var total = csharptest.Program.sumN1AndReversedN2(123, 123456);
            Console.WriteLine(total);
            Assert.True(total == 654444);
        }
    }
}