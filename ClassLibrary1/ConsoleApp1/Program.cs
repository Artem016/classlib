using ClassLibrary1;
using static ClassLibrary1.Class1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            Console.WriteLine(class1.GetRandomNumber());
        }
    }
}
