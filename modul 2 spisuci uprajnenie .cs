//zadacha 1 
string a=Console.ReadLine().Trim();
List<int> items = a.Split(' ').Select(int.Parse).ToList();

items.RemoveAll(x => x%2!=0);

Console.WriteLine(string.Join(" ", items));
