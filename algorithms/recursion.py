# loop backwards ou normal
def fatorial_iterativo(number):
    if number == 0:
        return 1
    count = number
    for i in range(number, 1, -1):
        count *= i-1
    return count

def fatorial_iterativo2(number):
    if number == 0:
        return 1
    count = 1
    for i in range(1, number+1):
        count *= i
    return count

def soma_iterativa(number):
    count = 0
    for i in range(1, number+1):
        count += i
    return count





# operações de forma recursiva
def fatorial_recursivo(number):
    if number == 1:
        return 1
    return number * fatorial_recursivo(number-1)


def soma_recursiva(number):
    if number == 1:
        return 1
    return number + soma_recursiva(number-1)
