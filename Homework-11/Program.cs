namespace Homework_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtusDictionary otusDictionary = new OtusDictionary();

            otusDictionary.Add(1, "value1");
            otusDictionary.Add(2, null);
            otusDictionary.Add(3, "value3");
            otusDictionary.Add(4, "value4");
            otusDictionary.Add(5, "value5");
            otusDictionary.Add(6, "value6");
            otusDictionary.Add(4, "value7");
            otusDictionary.Add(8, "value8");

            Console.WriteLine($"{otusDictionary.Get(1)}\n-----------");
            Console.WriteLine($"{otusDictionary.Get(2)}\n-----------");
            Console.WriteLine($"{otusDictionary.Get(3)}\n-----------");
            Console.WriteLine($"{otusDictionary.Get(4)}\n-----------");
            

            Console.ReadKey();
        }
    }
}