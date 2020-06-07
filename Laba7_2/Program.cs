using System;
using System.Collections.Generic;
namespace Laba7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Net>();

            Sort<Net> cp = new Sort<Net>();

            list.Add(new Net(1, "Петров","Петро","Львів",110,190));
            list.Add(new Net(3, "Петров", "Петро", "Львів", 140, 105));
            list.Add(new Net(5, "Петров", "Петро", "Львів", 125, 131));
            list.Add(new Net(2, "Петров", "Петро", "Львів", 130, 120));
            list.Add(new Net(4, "Петров", "Петро", "Львів", 121, 100));
            list.Add(new Net(6, "Петров", "Петро", "Львів", 122, 130));
            list.Add(new Net(7, "Петров", "Петро", "Львів", 120, 190));

            Console.WriteLine("Абоненти кабельної мережі до сортування : \n");
            foreach (Net a in list)
                Console.WriteLine(a);

            Console.WriteLine("Абоненти кабельної мережі після сортування за номером: \n");
            list.Sort();
            foreach (Net a in list)
                Console.WriteLine(a);

            Console.WriteLine("Каталог після сортировки за 2 параметрами: \n");
            list.Sort(cp);

            foreach (Net a in list)
                Console.WriteLine(a);


        }
    }
}
