zadacha 1 

  using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace spisuci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b;
            int scalpel = 0;
            int microscope = 0;
            int syringe = 0;
            double sum = 0;
            for (int i = 0; i < a; i++)
            {
                b = Console.ReadLine();
                switch (b)
                {
                    case "scalpel" :
                        scalpel++;
                        break;
                    case "microscope":
                        microscope++;
                        break;
                    case "syringe":
                        syringe++;
                        break;



                }
            }
            sum=scalpel * 1500 + microscope * 6000 + syringe * 100;
            Console.WriteLine(Math.Round(sum,2));
        }
        


    }
}

zadacha 2 


  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_kariera_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            while ((command = Console.ReadLine()).ToLower() != "end of owners")
            {
                switch (command.ToLower())
                {
                    case "add owner":
                        names.Add(Console.ReadLine());
                        break;
                    case "add owner on position":
                        string name = Console.ReadLine();
                        int i = int.Parse(Console.ReadLine());
                        names.Insert(i, name);
                        break;
                    case "remove owner on position":
                        i = int.Parse(Console.ReadLine());
                        names.RemoveAt(i);
                        break;
                    case "remove last owner":
                        names.RemoveAt(names.Count - 1);
                        break;
                    case "remove first owner":
                        names.RemoveAt(0);
                        break;
                }
            }
            foreach (string i in names)
            {
                Console.Write(i + " ");
            }
        }
    }
}
zadacha 3

  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It_kariera_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = "";
            string letters = "";
            string other = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
                else if (char.IsLetter(c))
                {
                    letters += c;
                }
                else
                {
                    other += c;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);

        }
    }
}


  

zadacha 4

  using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main(string[] args) {

    string input = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ') i++;
                
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 1);
                }
                else dict[input[i]]++;
            }

            foreach (char c in dict.Keys)
            {
                Console.WriteLine($"{c} -> {dict[c]}");
            }
    }
}
