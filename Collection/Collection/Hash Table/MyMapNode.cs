using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public struct KeyValue<k, v>
    {
        public k key { get; set; }
        public v value { get; set; }
    }
    class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;


        public MyMapNode (int size) 
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key) 
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key) 
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }
        public void Add (K key, V value) 
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
        }
        public void Remove (K key) 
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position) 
        {
            LinkedList<KeyValue<K, V>> linkeList = items[position];
            if (linkeList == null)
            {
                linkeList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkeList;
            }
            return linkeList;
        }
             
    }
}
