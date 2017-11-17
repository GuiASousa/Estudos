#include <stdio.h>

void main(void)
{
	int qtMeses,c;
	float valAplic,txJuros,valJur,valor;
	
	printf("Insira o valor aplicado: ");
	scanf("%f", &valAplic);
	printf("Insira a taxa de Juros: ");
	scanf("%f", &txJuros);
	printf("Insira a Quantidade de meses: ");
	scanf("%i", &qtMeses);
	
	valor = valAplic;
	for(c=1;c<=qtMeses;c++)
		valor = valor + valor * txJuros / 100;
	valJur = valor - valAplic;
	printf("R$%.2f", valJur);
}