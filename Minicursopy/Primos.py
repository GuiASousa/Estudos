def primo(x):
    if x == 2:
        return True
    else:
        if x % 2 == 0:
            print(False)
        else:
            for i in range(2, x):
                if (x % i) == 0:
                    print(False)
                else:
                    print(True)

a = int(input())
print(primo(a))