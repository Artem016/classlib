namespace ClassLibrary1
{
    public class Class1
    {
        public int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next();
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)a / b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }
    }
}
