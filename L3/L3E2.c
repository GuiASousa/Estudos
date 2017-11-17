#include<stdio.h>
void main(void){
	int c, positivos, negativos;
	float entrada;
	positivos = 0;
	negativos = 0;
	for(c=0;c<=9;c++)
	{
		printf("Insira a Entrada: ");
		scanf("%f",&entrada);
		if(entrada >= 0)
			positivos++;
		else
			negativos++;
	}
	printf("N: %i P: %i ",negativos, positivos);
}