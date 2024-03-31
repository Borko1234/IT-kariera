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
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double zaplata;

        public double Zaplata
        {
            get { return zaplata; }
            set { zaplata = value; }
        }
        private string dlujnost;

        public  string Dlujnost
        {
            get { return dlujnost; }
            set { dlujnost = value; }
        }
        private  string email;

        public  string Email
        {
            get { return email; }
            set { email = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public person(string name_out,double zaplata_out,string dlujnost_out,string email_out,int age_out)
        {
            this.Name = name_out;
            this.Zaplata = zaplata_out;
            this.Dlujnost = dlujnost_out;
            this.Email = email_out;
            this.Age = age_out;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string a;
            double b;
            string c;
            string d;
            int e;
            double max = int.MinValue;
            List<person> list = new List<person>();
            for(int i = 0; i < n; i++)
            {
                a= Console.ReadLine();
                b = double.Parse(Console.ReadLine());
                c=Console.ReadLine();
                d=Console.ReadLine();
                e=int.Parse(Console.ReadLine());
                person person=new person(a,b,c,d,e);
                list.Add(person);
            }
            foreach (person person in list)
            {
                if (person.Zaplata > max) ;
                max = person.Zaplata;
            }
            foreach(person per in list)
            {
                if (per.Zaplata == max)
                {
                    string x = per.Dlujnost;
                    list.RemoveAll(p => p.Dlujnost!=x);
                    var sortedList = list.OrderByDescending(p => p.Zaplata).ToList();
                    Console.WriteLine($"Highest paid department->{x}");
                    foreach(person p in sortedList)
                    {
                        Console.WriteLine(p.Name+" "+p.Zaplata+" "+p.Email+" "+p.Age);
                    }  
                }
            }


        } 
    }
}
