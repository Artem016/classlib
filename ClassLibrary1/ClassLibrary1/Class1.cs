namespace ClassLibrary1
{
    public class Class1
    {
        public int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next();
        }
    }
}
