#include<stdio.h>
void main(void){
	int num [10], cont, maior, menor;
	for(cont=0;cont<=9;cont++)
	{
		printf("Insira numero: ");
		scanf("%i", &num[cont]);
	}	
	maior = num[0];
	menor = num [0];
	for(cont=1;cont<=9;cont++)
	{
		if (num[cont] > maior)
			maior = num[cont];
		if (num[cont] < menor)
			menor = num[cont];
	}
	printf("Maior: %i, Menor: %i",maior, menor);
}