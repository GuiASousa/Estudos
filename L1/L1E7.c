#include<stdio.h>
void main(void){
	int numInicial, numSomado, num1, num2, num3, num4;
	printf("Insira o numero inicial de 4 algarismos: ");
	scanf("%i", &numInicial);
	num1 = numInicial % 10;
	num2 = numInicial % 100 / 10;
	num3 = numInicial % 1000 / 100;
	num4 = numInicial / 1000;
	numSomado = num1 + num2 + num3 + num4;
	printf("A soma dos algarismos %i eh %i", numInicial, numSomado);
}