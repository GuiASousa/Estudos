def dna(base1,base2):
    z = -1
    if len(base1) != len(base2): 
        print("Tamanhos diferentes!!")
    else:
        for x in (0,len(base1) - 1):
            if base1[x] + base2[x] == 'at' or base1[x] + base2[x] == 'ta' or base1[x] + base2[x] == 'gc' or base1[x] + base2[x] == 'cg':
                z += 1
            else:
                break
        if z == len(base1):
            return True
        else:
            return False
base1 = ['a','t','g','c']
base2 = ['t','a','c','g']
print(dna(base1,base2))