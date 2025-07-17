namespace DataStructureAndAlgorithms.Algorithms.Sorting;

public class Swap
{
    public static void __swap(int a, int b)
    // using an aux var
    {
        var aux = a;
        a = b;
        b = aux;
    }
    

    public void _swap(int a, int b)
    // tuple swaping
    {
        (a, b) = (b, a);
    }
}