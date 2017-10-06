class retangulo:
    lado_a = None
    lado_b = None
    def __init__(self,lado_a,lado_b):
        self.lado_a = lado_a
        self.lado_b = lado_b
        print('Retângulo Criado')
    def area(self):
        return self.lado_a * self.lado_b
    def perimetro(self):
        return 2 * self.lado_a + 2 * self.lado_b
    
r = retangulo(3,5)
print(r.perimetro())