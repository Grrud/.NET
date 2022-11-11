using System;
using System.Collections.Generic;

namespace lab6
{
    class Human
    {
        public string name { get; set; }
        public string city { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public bool marriage { get; set; }
    }



        class TryList
    {
        public static void Kisi()
        {
            var cats = new List<string>() { "lion", "tiger" };
            cats.Add("cheetah");
            cats.Add("fox");
            cats.Add("puma");
            for (int i = 0; i < cats.Count; i++)
            {
                string kisa = cats[i];
                Console.WriteLine(" {0} (=^. .^=)", kisa);
            }
            Console.WriteLine("fox isn't cat!");
            cats.Remove(cats[4]);
            for (int i = 0; i < cats.Count; i++)
            {
                string kisa = cats[i];
                Console.WriteLine(" {0} (=^. .^=)", kisa);
            }
            Console.WriteLine("add some cats");
            int choice = 1;
            while (choice-- > 0)
            {
                Console.Write("add cat right now===>");
                string addcats = Console.ReadLine();
                cats.Add(addcats);
                Console.Write("continue?");
                choice = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < cats.Count; i++)
            {
                string kisa = cats[i];
                Console.WriteLine(" {0} (=^. .^=)", kisa);
            }
        }

            public static void Hoooman()
            {
                var data = new List<Human>(3)
                {
                    new Human() { name = "Миша", city = "Lipetsk", age = 54, salary = 1, marriage = false },
                };
            Console.WriteLine("add people");
            int choice = 1;
            while (choice-- > 0)
            {
                data.Add(new Human() { name = Console.ReadLine(), city = Console.ReadLine(), age = Int32.Parse(Console.ReadLine()), salary = Int32.Parse(Console.ReadLine()), marriage = bool.Parse(Console.ReadLine()) });
                Console.Write("continue?");
                choice = Int32.Parse(Console.ReadLine());
            }
            foreach (Human human in data)
                {
                Console.WriteLine(human.name + " " + human.city + " " + human.age + " " + human.salary + " " + human.marriage);
                }

            }



            public static void Main()
        {
                Hoooman();

        }
    }
}
