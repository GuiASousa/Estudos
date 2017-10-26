#include<stdio.h>
void main(void){
	int numInicial, somaPar, somaImpar, num1, num2, num3, num4;
	printf("Insira o numero inicial de 4 algarismos: ");
	scanf("%i", &numInicial);
	num1 = numInicial % 10;
	num2 = numInicial % 100 / 10;
	num3 = numInicial % 1000 / 100;
	num4 = numInicial / 1000;
	somaImpar = 0;
	somaPar = 0;
	if (num1 % 2 == 0)
		somaPar += num1;
	else
		somaImpar += num1;
	if (num2 % 2 == 0)
		somaPar += num2;
	else
		somaImpar += num2;
	if (num3 % 2 == 0)
		somaPar += num3;
	else
		somaImpar += num3;
	if (num4 % 2 == 0)
		somaPar += num4;
	else
		somaImpar += num4;
	printf("A soma dos pares %i e impar %i", somaPar, somaImpar);
}