#include<stdio.h>
void main(void){
	
	float vDup, taxapDia, vTot;
	int diasAtraso, numDup;
	
	printf("Insira o numero da duplciata: ");
	scanf("%i", &numDup);
	printf("Insira o valor da duplciata: ");
	scanf("%f", &vDup);
	printf("Insira os dias de atraso: ");
	scanf("%i", &diasAtraso);
	printf("Insira a taxa por dia: ");
	scanf("%f", &taxapDia);
	taxapDia = taxapDia / 100;
	vTot = vDup + diasAtraso * taxapDia;
	printf("Numero da Duplicata: %i, e o valor total: %.2f", numDup, vTot);
}