from datetime import datetime
h = int(input("Horas: "))
m = int(input("Minutos: "))
s = int(input("Segundos: "))
f = 0
while f == 0:
    a = datetime.now()
    b = a.hour
    c = a.minute
    d = a.second
    if h == b and m == c and s == d:
        print("Bip!!!")
        f = 1
