def triangpitagorico():
    for i in range(1,11):
        for d in range(1,11):
            for f in range(1,11):
                if i**2 == d ** 2 + f ** 2 or d ** 2 == i ** 2 + f ** 2 or f **2 == i ** 2 + d ** 2:
                    print(i,d,f)

triangpitagorico()

