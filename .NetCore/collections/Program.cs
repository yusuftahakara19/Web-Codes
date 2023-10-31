using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace collections
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(42, "Konya");
            plakalar.Add(01, "Adana");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(35, "İzmir");
            Dictionary<int, string> sayilar = new Dictionary<int, string>(){
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"}
            };

            Console.WriteLine(plakalar[42]);

            foreach (var d in plakalar)
            {
                Console.WriteLine(d.Key + "-" + d.Value);
            }

            for (int i = 0; i < plakalar.Count; i++)
            {
                Console.WriteLine($"{plakalar.Keys.ElementAt(i)} - {plakalar[plakalar.Keys.ElementAt(i)]}");
            }

            Console.WriteLine("\n" + plakalar.ContainsKey(41));
            Console.WriteLine("\n" + plakalar.Contains(new KeyValuePair<int, string>(41, "Konya")));

            plakalar.Remove(35);

            Hashtable hs = new Hashtable();
            hs.Add(1, "ali");
            hs.Add(5, 15.5f);
            hs.Add("1", "Product");


        }


    }
}
