def selection_sort(arr: list) -> list:
    for i in range(len(arr)-1):
        lowest = i
        for j in range(i+1, len(arr)):
            if arr[j] < arr[lowest]:
                lowest = j
        if arr[lowest] < arr[i]:
            (arr[i], arr[lowest]) = (arr[lowest], arr[i])
    return arr

# observações:
  # lowest inicializado no loop de fora
  # armazeno os index ao inves dos valores

def selection_sort2(arr: list) -> list:
    for i in range(len(arr)-1, 0, -1):
        highest = i
        for j in range(i-1, -1, -1):
            if arr[j] > arr[highest]:
                highest = j
        if arr[highest] > arr[i]:
            (arr[i], arr[highest]) = (arr[highest], arr[i])
    return arr

# observações:
  # o segundo parametro de range, que é o limite do loop, é exclusivo (adicionar 1 a mais)