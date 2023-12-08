﻿namespace Hash_Tables
{
    internal class Book_KVP
    {
        private KeyValuePair<string, double>[] book;
        int index;
        public Book_KVP(int size)
        {
            book = new KeyValuePair<string, double>[size];
            index = 0;
        }

        internal void AddItem(string v1, double v2)
        {
            book[index] = new KeyValuePair<string, double>(v1, v2);
            index++;

        }

        internal double GetPrice(string v)
        {

           for (int i = 0; i < index; i++)
           {
                if (book[i].Key == v)
                {
                    return book[i].Value;
                }
           }
           return -1;

        }
    
        public override string ToString()
        {
            string s = "";
            foreach(KeyValuePair<string, double> kvp in book)
            {
                s = $"{s} {kvp.Key} - {kvp.Value}\n";
            }
            return s;
        }
    
    
    
    }
}