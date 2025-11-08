def fatorial_iterativo(number):
    if number == 0:
        return 1
    count = number
    for i in range(number, 1, -1):
        count *= i-1
    return count

print(fatorial_iterativo(0))