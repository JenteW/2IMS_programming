namespace Hash_Tables
{
    internal class Book_HashSep
    {
        private List<KeyValuePair<string, double>>[] book;
        public int NextPrime(double nr)
        {
            int number = (int)nr;
            bool isPrime = false;
            while (!isPrime)
            {
                isPrime = true;
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (!isPrime)
                {
                    number++;
                }

            }
            return number;

        }
        public Book_HashSep(int keys)
        {
            book = new List<KeyValuePair<string, double>>[NextPrime(keys * 1.3)];
        }
        private int HashFunction(string key)
        {
            /* int index = 0;
             foreach(char c in key)
             {
                 index += c; // char heeft symbolische waarde en ascii waarde
             }
             return index % book.Length;*/

            /* double index = 0;
             for(int i = 0; i < key.Length; i++)
             {
                 index += (int)key[i] + Math.Pow(31,i);
             }
             return (int)(index % book.Length);*/
             long index = 0;
            foreach (char c in key) index = (31 * index) + (int)c;
            return (int)(index % book.Length);
        }
        internal void AddItem(string product, double price)
        {
            int index = HashFunction(product);
            if (book[index] == null)
            {
                book[index] = new List<KeyValuePair<string, double>>();
            }
            book[index].Add(new KeyValuePair<string, double>(product, price));

        }

        internal double GetPrice(string product)
        {

            int index = HashFunction(product);
            foreach (var item in book[index])
            {
                if (item.Key == product)
                {
                    return item.Value;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < book.Length; i++)
            {
                if (book[i] != null)
                {
                    foreach (var item in book[i])
                    {
                        s = $"{s} - {item.Key} {item.Value}\n";
                    }
                }
                else s += "null\n";
            }
            return s;
        }
    }
}