using System;

namespace lab5
{
    class t1
    {
        public static void doubleword()
        {
            Console.WriteLine("Ваше слово:");
            string word =  Console.ReadLine();
            int i = 0;
            foreach (var c in word)
            {
                Console.Write("{0}", word[i]);
                Console.Write("{0}", word[i]);
                i++;
            }
               
                
           
            Console.WriteLine();
        }
        public static void printwords()
        {
            Console.WriteLine("Вашb словf:");
            string words = Console.ReadLine();
            var d = words.Split(new char[] { '.' });
            string wordswihtoutdot = d[0];
            int count = 0;
            Console.WriteLine(" СТРОКА  d ----->{0}", d);
            var g = wordswihtoutdot.Split(new char[] { ' ' });
            foreach (var word in g)
            {
                count++;
            }
            
            foreach (var word in g)
            {
              if (word != g[count - 1])
                {
                    if (word.Length%2 ==0)
                    {
                        Console.WriteLine("{0} четное количество; ",word);
                    }
                    else
                    {
                        int j = word.Length / 2;
                        string partialword = word.Remove(j, 1); 
                        Console.WriteLine("{0} нечетное количество; ", partialword);
                        
                    }
                    
               }
               
            }
            Console.WriteLine("КОНЕЦ СТРОКИ");
         
        }

        public static void Main()
        {
            printwords();
            doubleword();
            doubleword();
        }
    }
}