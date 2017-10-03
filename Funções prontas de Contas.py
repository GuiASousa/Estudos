def soma (a, b):
    return arredondar(a + b)


def subtracao(a, b):
    return arredondar(a - b)


def multiplicacao(a, b):
    return arredondar(a * b)


def divisao(a, b):
    if b == 0:
        return 0
    else:
        return arredondar(a / b)


def arredondar(num):
    return float('%g' % (num))