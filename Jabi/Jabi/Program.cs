﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            Lake lake = new Lake(stones);
            foreach(int stone in lake) { 
            Console.Write(stone+" ");
            }

        }
    }
}
