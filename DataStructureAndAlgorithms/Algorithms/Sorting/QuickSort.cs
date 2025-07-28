namespace DataStructureAndAlgorithms.Algorithms.Sorting;

public class QuickSort
{
    public static void Sort(int[] arr, int left, int right)
    {
        // caso base da chamada recursiva
        if (left < right)
        {
            /* particionar a array com base no pivot e chamar recursivamente o metodo nas partições
                (passo a array, o left e right das partições) */
            var pi = Partition(arr, left, right);
            Sort(arr, left, pi - 1);
            Sort(arr, pi + 1, right);
        }
               
    }

    private static int Partition(int[] arr, int left, int right)
    {
        // escolher o pivot, iniciar os ponteiros (i, j)
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        // colocar o pivot na posição entre as 2 partições e retornar a posição dele
        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
        return i + 1;
    }
}