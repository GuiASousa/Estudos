#include<stdio.h>
void main(void){
	int dias;
	float valorDiario, valorPagar;
	
	printf("Insira os dias: ");
	scanf("%i", &dias);
	printf("Insira o valor da diaria: ");
	scanf("%f", &valorDiario);
	valorPagar = valorDiario * dias;
	printf("O valor a ser pago eh R$%.2f", valorPagar);
}