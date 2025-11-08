def fibonacci(idx):
    if idx == 1:
        return 0
    elif idx == 2:
        return 1
    
    else:
        return fibonacci(idx -1) + fibonacci(idx -2)
    
print(fibonacci(6))