using FiniteFields;

namespace CSR
{
    class Program
    {
        public static void Main(string[] args) 
        {
            List<byte[]> coef = new List<byte[]> { new byte[] { 2, 0, 0, 0 }, new byte[] { 3, 0, 0, 0 } };
            byte[] absVal = new byte[] { 0, 0, 0, 0 };
            List<byte[]> initVal = new List<byte[]> { new byte[] { 0, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };

            var generator = new Generator(absVal, coef, initVal);
            for(var i =0; i< 10; i++) generator.Generate();
        }

    }
}