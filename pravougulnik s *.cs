namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a=Console.ReadLine();
    List<string> items = a.Split(' ').ToList();
    List<int> nums = new List<int>();
    for (int i = 0; i < items.Count; i++)
        nums.Add(int.Parse(items[i]));



        }
    }
}
