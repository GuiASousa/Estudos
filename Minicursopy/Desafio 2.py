def primo(x):
    if x == 2:
        return True
    else:
        if x % 2 == 0:
            return False
        else:
            for i in range(2, x):
                if (x % i) != 0:
                    return True
                else:
                    return False
def fato(x):
    for i in range(1,100):
        if x == 1:
            break
        if primo(x) == True:
            print(x)
        else:
            for d in range(2, 100):
                if d == True:
                    if x % d == 0:
                        x = x / d
                        print(d)
                    else:
                        break
x = int(input())
fato(x)