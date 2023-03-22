using FiniteFields;

namespace CSR
{
    class Program
    {
        public static void Main(string[] args) 
        {
            FiniteField field = new FiniteField(2, 8, new int[] { 1, 1, 0, 1, 1, 0, 0, 0, 1 });
            FiniteFieldElements el = new FiniteFieldElements(new int[] { 1,1, 0},field);
            List<byte[]> coef = new List<byte[]> { new byte[] { 2, 0, 0, 0 }, new byte[] { 3, 0, 0, 0 } };
            byte[] absVal = new byte[] { 0, 0, 0, 0 };
            List<byte[]> initVal = new List<byte[]> { new byte[] { 0, 0, 0, 0 }, new byte[] { 1, 0, 0, 0 } };
            var generator = new Generator(absVal, coef, initVal);
            generator.Generate();
            generator.Generate();
            generator.Generate();
            foreach (var i in generator.Generate())
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(el.GetToBinary()[0]);
        }

    }
}