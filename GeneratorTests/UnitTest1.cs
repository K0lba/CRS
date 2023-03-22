using CSR;
using System.Runtime.ConstrainedExecution;

namespace GeneratorTests
{
    public class Tests
    {
        [Test]
        public void Generate1()
        {
            List<byte[]> coef = new List<byte[]> { new byte[]{ 2, 0, 0, 0 }, new byte[] { 3, 0, 0, 0 } };
            byte[] absVal = new byte[] { 0, 0, 0, 0 };
            List<byte[]> initVal = new List<byte[]> { new byte[] { 0, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte[]> { new byte[] { 3, 0, 0, 0 }, new byte[] { 7, 0, 0, 0 }, new byte[] { 15, 0, 0, 0 }, new byte[] { 31, 0, 0, 0 } };
            var result = new List<byte[]> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };
            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void ZeroTest1()
        {
            List<byte[]> coef = new List<byte[]> { new byte[] { 2, 0, 0, 0 }, new byte[] { 3, 0, 0, 0 }, new byte[] { 4, 0, 0, 0 } };
            byte[] absVal = new byte[] { 0, 0, 0, 0 };
            List<byte[]> initVal = new List<byte[]> { new byte[] { 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0 } };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte[]> { new byte[] { 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0 } };
            var result = new List<byte[]> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };

            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void OneTest1()
        {
            List<byte[]> coef = new List<byte[]> { new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };
            byte[] absVal = new byte[] { 1, 0, 0, 0 };
            List<byte[]> initVal = new List<byte[]> { new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte[]> { new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };
            var result = new List<byte[]> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };

            Assert.That(result, Is.EqualTo(expect));
        }
    }
}