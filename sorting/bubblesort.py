def bubble_sort(arr):
    for i in range(len(arr)):
        for j in range(0, len(arr)-i -1):
            if arr[j] > arr[j+1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
    return arr
# o limite do range do for interno é len(arr)-i -1 pois só é 
# iterado até o penúltimo elemento, o j+1 que vai comparar com
# o último e colocar o maior elemento da iteração no final da array
# relativa à iteração