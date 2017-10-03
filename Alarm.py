from datetime import datetime
h = int(input("Horas: "))
m = int(input("Minutos: "))
s = int(input("Segundos: "))
f = 0
while True:
    a = datetime.now()
    b = a.hour
    c = a.minute
    d = a.second
    if f == 1 :
        break
    elif h == b and m == c and s == d:
        print("Ai sim Boy")
        f = 1
