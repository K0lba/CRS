using FiniteFields;

namespace CRS
{
    public class Generator
    {
        private FiniteField field = new FiniteField(2,8,new int[] { 1, 1, 0, 1, 1, 0, 0, 0, 1 });
        private int k { get; set; }
        private FiniteFieldElement[] Coef { get; set; }
        private FiniteFieldElement C { get; set; }
        private FiniteFieldElement[] InitialVar { get; set; }
        public Generator(byte c, List<byte> coef, List<byte> initVal)
        {
            C = field.CreateElementFromBinary(c);
            k = coef.Count;
            Coef = new FiniteFieldElement[k];
            InitialVar = new FiniteFieldElement[k];
            for (int i = 0; i < k; i++)
            {
                Coef[i] = field.CreateElementFromBinary(coef[i]);
                InitialVar[i] = field.CreateElementFromBinary(initVal[i]);
            }
        }
        public byte Generate()
        {
            FiniteFieldElement x_n = new FiniteFieldElement(new int[] { 0 }, field);
            for (int i = 0; i <= k - 1; i++)
            {
                x_n += Coef[i] * InitialVar[i];
            }
            x_n += C;
            for (int i = 0; i < InitialVar.Length - 1; i++)
                InitialVar[i] = InitialVar[i + 1];
            InitialVar[InitialVar.Length-1] = x_n;
            return x_n.GetToBinary();
        }
    }
}
