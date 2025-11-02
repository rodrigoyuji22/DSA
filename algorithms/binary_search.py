[1,3,4,7,9]
def binary_search(arr ,target):
    l, r = 0, len(arr)-1
    while l <= r:
        guess = (l+r)//2
        if target == arr[guess]:
            return guess
        elif arr[guess] > target:
            r = guess-1
        else:
            l = guess+1
    return None

# observações:
  # pegar o ultimo elemento é len(arr)-1, eu fiz len(arr-1) na primeira tentativa
  # / barra simples retorna float, // retorna inteiro
  # para comparar o valor de target com o que está na posição de guess, arr[guess]

