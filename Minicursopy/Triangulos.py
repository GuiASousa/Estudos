def maior(x,y):
    if x > y:
        return x
    else:
        return y

def ehtriangulo(x,y,z):
    return maior(x,maior(y,z)) < x+y+z - maior(x,maior(y,z))

def classificatriangulo(x,y,z):
    if ehtriangulo(x,y,z) == False:
        return 'Nop, não é triângulo'
    else:
        if x == y and y == z:
            return 'Equilatero'
        else:
            if x != y and x != z and y != z:
                return 'Escaleno'
            else:
                return 'Isóceles'

a = int(input())
b = int(input())
c = int(input())
print(classificatriangulo(a,b,c))
