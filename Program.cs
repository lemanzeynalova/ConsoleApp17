namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int n = 20;
            int a = 0;
            int b = 1;
            Console.WriteLine("Fibonacci ardicilligi:");
            while(a<=n)
            {
                Console.WriteLine(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();

        }
    }
    static void A()
    {
        int a = 14;
        int b = 9;
        Console.WriteLine("evvel:");
        Console.WriteLine("a->"+a);
        Console.WriteLine("b->" +b);
        a = a - b;
        b = a + b;
        a = b - a;
        Console.WriteLine("sonra:");
        Console.WriteLine("a->"+a);
        Console.WriteLine("b->" +b);
    }
}