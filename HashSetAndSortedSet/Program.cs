using System;
using System.Collections.Generic;

namespace HashSetAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HashSet
            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");
            //set.Add("Smartphone");

            //foreach (string item in set)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SortedSet

            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 3, 15, 5, 6, 8, 10 };

            //SortedSet<int> b = new SortedSet<int>() { 4, 5, 6, 7, 8, 15, 9, 2, 10, 11, 12, 13 };

            //PrintCollection(a);
            //PrintCollection(b);

            ////Union
            //Console.WriteLine("\nUnion");
            //SortedSet<int> c = new SortedSet<int>(a);

            //c.UnionWith(b);
            //PrintCollection(c);

            ////Intersection
            //Console.WriteLine("\nIntersection");
            //SortedSet<int> d = new SortedSet<int>(a);

            //d.IntersectWith(b);
            //PrintCollection(d);

            ////Difference
            //Console.WriteLine("\nDifference");
            //SortedSet<int> e = new SortedSet<int>(a);

            //e.ExceptWith(b);
            //PrintCollection(e);




            #endregion

           

            Console.ReadKey();
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        
    }
}
