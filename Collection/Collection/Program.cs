using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Demo");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(72);
            binarySearch.Display();
            binarySearch.GetSize();
        }
    }
}
