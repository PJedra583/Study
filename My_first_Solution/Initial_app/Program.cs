

internal class Program
{
    public static void Main(string[] args)
    {
        int[] tab = { 2, 3, 4, 5 };
        Console.WriteLine(max(tab));   
    }
    public static double max(int[] COLLECTION)
    {
        double x = 0;
        foreach (var VARIABLE in COLLECTION)
        {
            x += VARIABLE;
        }

        return x / COLLECTION.Length;
    }
}