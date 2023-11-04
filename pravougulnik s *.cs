namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write('*');
                Console.Write(new string(' ', n - 2));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', n));



        }
    }
}
