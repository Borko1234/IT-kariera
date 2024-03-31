using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace spisuci
{
    public class person
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int year;
        public int Age
        {
            get { return year; }
            set { year = value; }
        }
        public person(string name_out,int age_out) {
        year = age_out;
        name = name_out;
        }

    }
    public class Family
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b;
            List<person> list = new List<person>();
            for (int i = 0; i < n; i++)
            {
                
                string a = Console.ReadLine();
                b = int.Parse(Console.ReadLine());
                person person = new person($"{a}", b);
                list.Add(person);

            }
            list.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            foreach (person person in list)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        } 
    }
}



//задача статистика
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace spisuci
{
    public class person
    {
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int year;
        public int Age
        {
            get { return year; }
            set { year = value; }
        }
        public person(string name_out,int age_out) {
        year = age_out;
        name = name_out;
        }

    }
    public class Family
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b;
            List<person> list = new List<person>();
            for (int i = 0; i < n; i++)
            {
                
                string a = Console.ReadLine();
                b = int.Parse(Console.ReadLine());
                person person = new person($"{a}", b);
                list.Add(person);

            }
            list.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
            list.RemoveAll(person => person.Age < 18);
            foreach (person person in list)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }


        } 
    }
}
