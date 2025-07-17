namespace DataStructureAndAlgorithms.Algorithms.Sorting;

public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            if (minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
                // tuple swaping instead of using a var aux to change the values
            }
        }
    }
}