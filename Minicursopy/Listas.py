def crivo(n):
    c = []
    d = []
    for x in range(2, n):
        if d.count(x) == 0:
            c.append(x)
            for y in range(1,n // x+1):
                if d.count(x * y) == 0: d.append(x * y)
    return c

print(crivo(10))