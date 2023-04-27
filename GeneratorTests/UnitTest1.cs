using CRS;
using System.Runtime.ConstrainedExecution;

namespace GeneratorTests
{
    public class Tests
    {
        [Test]
        public void Generate1()
        {
            List<byte> coef = new List<byte> { 2, 3};
            byte absVal = 0;
            List<byte> initVal = new List<byte> { 0, 1 };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte> { 3, 7, 15, 31 };
            var result = new List<byte> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };
            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void ZeroTest1()
        {
            List<byte> coef = new List<byte> { 2, 3, 2 };
            byte absVal = 0;
            List<byte> initVal = new List<byte> { 0, 0, 0 };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte> { 0, 0, 0, 0 };
            var result = new List<byte> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };

            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void OneTest1()
        {
            List<byte> coef = new List<byte> { 1, 1 };
            byte absVal = 1;
            List<byte> initVal = new List<byte> { 1, 1 };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte> { 1, 1, 1, 1 };
            var result = new List<byte> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };

            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void Generate2()
        {
            List<byte> coef = new List<byte> { 1, 3, 2 };
            byte absVal = 2;
            List<byte> initVal = new List<byte> { 2, 2, 1 };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte> { 4, 11, 25, 41 };
            var result = new List<byte> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };
            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void Generate3()
        {
            List<byte> coef = new List<byte> { 1, 1 };
            byte absVal = 4;
            List<byte> initVal = new List<byte> { 1, 1 };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte> { 4, 1, 1, 4 };
            var result = new List<byte> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };
            Assert.That(result, Is.EqualTo(expect));
        }

        [Test]
        public void Generate4()
        {
            List<byte> coef = new List<byte> { 1, 0, 1 };
            byte absVal = 4;
            List<byte> initVal = new List<byte> { 2, 1, 2 };

            var generator = new Generator(absVal, coef, initVal);
            var expect = new List<byte> { 4, 1, 7, 7 };
            var result = new List<byte> { generator.Generate(), generator.Generate(), generator.Generate(), generator.Generate() };
            Assert.That(result, Is.EqualTo(expect));
        }
    }
}