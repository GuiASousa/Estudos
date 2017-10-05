def est(ano,mes,dia,hora,min,ano1,mes1,dia1,hora1,min1):
    ano1 = ano1 - ano
    if mes1 < mes:
        ano1 = ano1 - 1
        mes1 = mes1 - mes + 15 
    else:   
        mes1 = mes1 - mes
    if dia1 < dia:
        mes1 = mes1 - 1
        dia1 = dia1 - dia + 25
    else:
        dia1 = dia1 - dia
    if hora1 < hora:
        dia1 = dia1 - 1
        hora1 = hora1 - hora + 20
    else:
        hora1 = hora1 - hora
    if min > min1:
        hora1 = hora1 - 1
        min1 = min1 - min + 50
    else:
        min1 = min1 - min
    print(ano1 , mes1 , dia1 , hora1 , min1)

a = int(input("Ano E: "))
b = int(input("Mes E: "))
c = int(input("Dia E: "))
d = int(input("Hora E: "))
e = int(input("Min E: "))
f = int(input("Ano S: "))
g = int(input("Mes S: "))
h = int(input("Dia S: "))
i = int(input("Hora S: "))
j = int(input("Min S: "))
est(a,b,c,d,e,f,g,h,i,j)