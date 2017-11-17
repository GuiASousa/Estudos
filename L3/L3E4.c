#include <stdio.h>

void main(void)
{
	int entrada, alg, algF;
	algF = 0;
	printf("Insira a Entrada: ");
	scanf("%i", &entrada);
	do{
		alg = entrada % 10;
		entrada /= 10;
		algF += alg;
		if(entrada > 0)
			algF *= 10;
	}while(entrada > 0);
	printf("%i", algF);
}