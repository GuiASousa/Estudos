#include <stdio.h>

void main(void)
{
	int numPlaca, horaEnt, horaSai, totalmin;
	float valPagar, totFatur;
	totFatur = 0;
	printf("Insira o numero da placa: ");
	scanf("%i", &numPlaca);
	while (numPlaca > 0)
	{
		printf("Insira a hora de entrada: ");
		scanf("%i", &horaEnt); //330
		printf("Insira a hora de saida: ");
		scanf("%i", &horaSai); //450
		totalmin = (horaSai / 100) * 60 + (horaSai % 100) - ((horaEnt / 100) * 60 + (horaEnt % 100));			
		valPagar = (totalmin / 15) * 1.5;
		totFatur += valPagar;
		printf("Insira o numero da placa: ");
		scanf("%i", &numPlaca);
	}
	printf("R$%.2f", totFatur);
}