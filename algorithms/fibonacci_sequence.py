def fibonacci(idx):
    if idx == 1:
        return 0
    elif idx == 2:
        return 1
    
    else:
        return fibonacci(idx -1) + fibonacci(idx -2)
    
print(fibonacci(6))

# sequencia de fibonacci [0,1,1,2,3,5,8,13,21,34]
# sendo 0 o valor da posição 1, e 1 o valor da posição 2 e 3.