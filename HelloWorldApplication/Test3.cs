namespace CalculatorApplication
{
    public class Test3
    {
        private int length;
        private int width;
        public Test3(int l, int w)
        {
            length = l;
            width = w;
            
        }

        public int getArea()
        {
            return length * width;
        }

        public int Length
        {
            get => length;
            set => length = value;
        }
    }
}