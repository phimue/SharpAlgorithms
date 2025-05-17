using Algorithms.Implementations;

int[] a = [5, 2, 4, 6, 1, 3];

InsertionSort insertionSort = new InsertionSort(a);

foreach(int i in a)
{
    Console.WriteLine(i);
}

Console.WriteLine();

int[] b = insertionSort.Sort();

foreach(int j in b)
{
    Console.WriteLine(j);
}
