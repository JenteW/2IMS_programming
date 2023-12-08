namespace Hash_Tables
{
    internal class Book_Hash
    {
        private double[] book;
        

        public int NextPrime(double nr)
        {
            int number = (int)nr;
            bool isPrime = false;
            while (!isPrime)
            {
                isPrime = true;
                for (int i = 2; i < number/2; i++)
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
        public Book_Hash(int keys)
        {

            book = new double[NextPrime(keys*1.3)];

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
            book[index] = price;
        }

        internal double GetPrice(string product)
        {
            return book[HashFunction(product)];
        }

        public override string ToString()
        {
            return String.Join(" ", book);
        }
    }
}