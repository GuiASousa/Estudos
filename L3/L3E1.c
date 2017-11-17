#include<stdio.h>
#include<conio.h>
void main(void){
	int entrada, saida, c;
	for(c=0;c<=9;c++)
	{
		printf("\nInsira a Entrada: ");
		scanf("%i",&entrada);
		saida = entrada * 2;
		printf("%i", saida);
	}
}