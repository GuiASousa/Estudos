def soma(a, b):
    d = a + b
    return(d)
def sub(a, b):
    d = a - b
    return(d)
def mult(a, b):
    d = a * b 
    return(d)
def div(a, b):
    d = a / b
    return(d)
c=0
while c != 5:
    c = int(input('''Entre 1 das opções para continuar '
              '1- Soma '
              '2- Subtração '
              '3- Multiplicação '
              '4- Divisão '
              '5- Sair: '''))
    if c==5:
        break
    elif c>5 or c<=0:
        print('Erro')
    else:
        a = int(input('a: '))
        b = int(input('b: '))
        if c==1:
            d=soma(a, b)
            print(d)
        elif c==2:
            d=sub(a, b)
            print(d)
        elif c==3:
            d=mult(a, b)
            print(d)
        elif c==4:
            if b==0:
                print('erro')
            else:
                d=div(a, b)
                print(d)
        


    
