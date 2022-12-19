﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_Exercise
{
    public class Program
    {
        public static void Main()
        {
            ArrayList cuvinte = new ArrayList()
                    {
                        "pepene", "ananas", "mar", "strugure", "banana"
                    };

            cuvinte.Sort();

            Queue<string> cuvinteCoada = new Queue<string>();

            foreach (var cuvant in cuvinte)
            {
                cuvinteCoada.Enqueue(cuvant.ToString());
            }
            Console.WriteLine("Coada contine: ");
            foreach (var cuvant in cuvinte)
            {
                Console.WriteLine(cuvant.ToString());
            }
            cuvinte.Clear();

            if (cuvinte.Count==0)
                Console.WriteLine("ArrayList-ul este gol");
        }
    }
}


