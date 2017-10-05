def fatorial(x):
    if x == 0 or x == 1:
        return 1
    else:
        v = 1
        for x in range(2,x+1):
            v *= x
        return v
def fibonacci(n):
    if n == 0: return 1
    if n == 1: return 1
    return fibonacci(n-1) + fibonacci(n-2)

def wfibonacci(n):
    c = 0
    f = fibonacci(n)
    while f <= n:
        print(f)
        c += 1
        f = fibonacci(c)
wfibonacci(10)