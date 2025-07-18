namespace DataStructureAndAlgorithms.Algorithms.Sorting;

public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            var minIndex = i;
            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            if (minIndex != i)
            {
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
                // tuple swaping instead of using an aux var to change the values
            }
        }
    }
}