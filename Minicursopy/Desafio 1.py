def gerarNum(n):
    for x in range(0, n+1):
        for e in range(0, n+1):
            for d in range(0, n+1):
                print(x,e,d)


n = int(input())
gerarNum(n)
