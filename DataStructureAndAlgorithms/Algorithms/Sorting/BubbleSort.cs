namespace DataStructureAndAlgorithms.Algorithms.Sorting;

public class BubbleSort
{
    public static void _bbSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            var isSorted = true;
            for (int j = 0; j < arr.Length -1 -i; j++) // itera ate o penultimo pois a comparação é com o indice adjacente, e reduz o tamanho por iteração com i
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                    isSorted = false;
                }
            }
            if (isSorted)
            {
                return;
                // early stopping caso ja estiver ordenado, pois se chegar ate a condicional onde ocorre o swap, está desordenado
            }
        }
    }
}