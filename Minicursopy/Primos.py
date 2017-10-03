def primo(x):
    if x == 2:
        return True
    else:
        if x % 2 == 0:
            return False
        else:
            for i in range(2, x ** 0.5):
                if (x % i) == 0:
                    return False
                else:
                    return True

a = int(input())
print(primo(a))
