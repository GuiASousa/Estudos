from datetime import datetime

def horas():
    a = datetime.now()
    return a.time()


def data():
    a = datetime.now()
    return a.date()
