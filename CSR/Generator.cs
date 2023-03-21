using FiniteFields;

namespace CSR
{
    public class Generator
    {
        private FiniteField field = new FiniteField(2,8,new int[] { 1, 1, 0, 1, 1, 0, 0, 0, 1 });
        private int k { get; set; }
        private FiniteFieldElements[] Coef { get; set; }
        private FiniteFieldElements C { get; set; }
        private FiniteFieldElements[] InitialVar { get; set; }
        public Generator(byte[] c, List<byte[]> coef, List<byte[]> initVal)
        {
            C = field.CreateElementFromBinary(c);
            k = coef.Count;
            Coef = new FiniteFieldElements[k];
            InitialVar = new FiniteFieldElements[k];
            for (int i = 0; i < k; i++)
            {
                Coef[i] = field.CreateElementFromBinary(coef[i]);
                InitialVar[i] = field.CreateElementFromBinary(initVal[i]);
            }
        }
        public byte[] Generate()
        {
            FiniteFieldElements x_n = new FiniteFieldElements(new int[] { 0 }, field);
            for (int i = 0; i <= k - 1; i++)
            {
                x_n += Coef[i] * InitialVar[i];
            }
            x_n += C;
            for (int i = 0; i < InitialVar.Length - 1; i++)
                InitialVar[i] = InitialVar[i + 1];
            InitialVar[InitialVar.Length] = x_n;
            return x_n.GetToBinary();
        }
    }
}
