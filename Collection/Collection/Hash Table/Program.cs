using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Demo");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To"); // It will Add Index to the Hash Table at Respective Position
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th Index Value: " +hash5);
            hash.Remove("2"); // It will Remove the Index Value at Respective Position
            string hash2 = hash.Get("2");
            Console.WriteLine("2nd Index is: " +hash2);
        }
    }
}
