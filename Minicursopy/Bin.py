Entrada = int(input('Bin: '))
V = []
while True:
    if Entrada > 0:
        Resto = Entrada % 2
        Entrada = Entrada // 2
        V.append(Resto)
    else:
        break
print(V)