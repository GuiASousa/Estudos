def fatorial(x):
    if x == 0 or x == 1:
        return 1
    else:
        v = 1
        for x in range(2,x+1):
            v *= x
        return v

a = int(input())
print(fatorial(a))


         