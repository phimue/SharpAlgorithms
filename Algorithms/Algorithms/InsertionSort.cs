namespace Algorithms
{
    internal class InsertionSort
    {
        int[] A { get; set; }

        internal InsertionSort(int[] a) 
        {
            this.A = a;
        }

        internal int[] Sort()
        {
            int[] a = new int[A.Length];
            A.CopyTo(a, 0);

            for(int j = 1; j < a.Length; j++)
            {
                int key = a[j];
                int i = j - 1;
                while (i >= 0 && a[i] > key)
                {
                    a[i + 1] = a[i];
                    i = i - 1;
                }
                a[i+1] = key;
            }

            return a;
        }
    }
}
