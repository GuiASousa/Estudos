def conta (v):
    n1 = v % 10
    n2 = ((v % 100) - n1) // 10
    n3 = ((v % 1000) - n1 - n2) // 100
    n4 = v // 1000
    return n1, n2, n3, n4


v = int(input('Insira um valor de 4 dígitos: '))
n1, n2, n3, n4 = conta(v)
m = int(input('''O que deseja fazer com o valor ?
1- Soma dos algarísmos
2- Inversão dos algarísmos :
'''))
if m == 2:
    print('%d%d%d%d' % (n1, n2, n3, n4))
else:
    print(n1 + n2 + n3 + n4)
