using Algorithms.Sort;

int[] a = [5, 2, 4, 6, 1, 3];

foreach(int i in a)
{
    Console.WriteLine(i);
}

Console.WriteLine();

int[] b = InsertionSort.Sort(a);

foreach(int j in b)
{
    Console.WriteLine(j);
}
