//zadacha 1 
string a=Console.ReadLine().Trim();
List<int> items = a.Split(' ').Select(int.Parse).ToList();
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
            string a = Console.ReadLine().Trim();
            List<int> items = a.Split(' ').Select(int.Parse).ToList();
            List<int> bestpovt = new List<int>();
            List<int> povt = new List<int>();
            int b = 0;
            int c = 0;
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i]==items[i+1])
                {
                    if (items[i] == items[i-1]) {
                        bestpovt.Add(items[i]);
                        b++;
                    }
                    else
                    {
                        povt.Add(items[i]);
                        c++;
                    }
                   
                   
                }
            }
            if (c > b)
            {
                for(int i = 0;i < povt.Count;i++)
                {
                    Console.Write(povt[i]);
                }
            }
            else
            {
                for(int i = 0;i<bestpovt.Count;i++)
                {
                    Console.Write(bestpovt[i]);
                    
                }
            }
           

        }   
    }
}
