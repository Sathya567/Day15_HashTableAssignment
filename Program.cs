using System;

namespace Day15_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program");

            //            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);              UC_1
            //            hash.Add("0", "to");
            //            hash.Add("1", "be");
            //            hash.Add("2", "or");
            //            hash.Add("3", "not");
            //            hash.Add("4", "to");
            //            hash.Add("5", "be");

            //            Console.WriteLine("Frequency of to  : " + hash.GetFrequencyOfWords("to"));
            //            Console.WriteLine("Frequency of be  : " + hash.GetFrequencyOfWords("be"));
            //            Console.WriteLine("Frequency of or  : " + hash.GetFrequencyOfWords("or"));
            //            Console.WriteLine("Frequency of not : " + hash.GetFrequencyOfWords("not"));

            //    string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            //    string[] para = paragraph.Split(" ");
            //    MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            //    int key = 0;
            //    foreach (string word in para)                                                                UC_2
            //    {
            //        hash.Add(key, word);
            //        key++;
            //    }
            //    Frequency frequency = new Frequency();
            //    frequency.Freqncy(hash);
            //}

            Console.WriteLine();


            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(para.Length);
            int keys = 0;
            foreach (string word in para)
            {
                int k = keys++;
                string key = k.ToString();
                hash.Add(word, key);
            }
            string value = hash.Get("Paranoids");
            hash.GetArrayPosition(value);
            hash.Remove("avoidable");
        }
    }
}

    
