using System;
using System.Collections.Generic;

namespace HW_1_09_03_21
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> my = new MyDictionary<int, string>();
            my.Add(1, "5");
            my[1] = "6";
            Console.WriteLine(my[1]);
            MyDictionary<string, int> m = new MyDictionary<string,int>();
            m.Add("1", 1);
            m["1"] = 1234;
            Console.WriteLine(m["1"]);
            int a = m["1"];
            Console.WriteLine(m["1"]);
            MyDictionary<int, Person> l = new MyDictionary<int, Person>();
            l.Add(1, new Person());
            l.Values[0].name = "ABCDE";
            l[1].name = "E";
            MyDictionary<int,string> dsa = new MyDictionary<int,string>();
            dsa.Add(1,"A");
            dsa.Add(23212, "2");
            foreach (var keys in dsa.Keys)
            {
                Console.WriteLine(keys);
            }
            foreach (var values in dsa.Values)
            {
                Console.WriteLine(values);
            }
          
            Console.ReadKey();

            Dictionary<int, string> mydiction = new Dictionary<int, string>();
            mydiction.Add(1, "1");
            mydiction.Add(2, "2");
            foreach (var items in mydiction)
            {
                Console.WriteLine(items);
                Console.WriteLine(items.Key);
                Console.WriteLine(items.Value);
            }
            Console.Read();
        }
    }
}
