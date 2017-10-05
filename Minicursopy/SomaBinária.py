def somaBin(bin1,bin2):
    resto = 0
    for e in range(7, -1, -1):
        somado[e] = bin1[e] + bin2[e] + resto
        if somado[e] > 1:
            if somado[e] == 2:
                resto = 1
                somado[e] -= 2
            elif somado[e] == 3:
                resto = 1
                somado[e] -= 2
        else:
            resto = 0
    return somado
bin1 = []
bin2 = []
somado = [0,0,0,0,0,0,0,0]

for x in range(0,8):
    bin1.append(int(input('Binário 1: ')))
for d in range(0,8):
    bin2.append(int(input('Binário 2: ')))
print(somaBin(bin1,bin2))
