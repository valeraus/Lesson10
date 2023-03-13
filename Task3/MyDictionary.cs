namespace Task3
{
    class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }
        public void Add(int i, TKey k, TValue l)
        {
            key[i] = k;
            value[i] = l;
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Спроба звернення за межі масиву.";
            }
        }
        public int Lenght
        {
            get { return lenght; }
        }
    }
}
    