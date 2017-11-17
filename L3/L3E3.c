#include<stdio.h>
#include<conio.h>
void main(void){
	char tipo;
	float valor, valorF;
	int id;
	valorF = 0;
	printf("Insira o id: ");
	scanf("%i", &id);
	while(id>0)
	{
		printf("Insira o valor: ");
		scanf("%f", &valor);
		printf("Insira o tipo: ");
		tipo = getche();
		if(tipo == 'E' || tipo == 'e')
			valor *= 0.75;
		if(tipo == 'I' || tipo == 'i')
			valor *= 0.65;
		else
			valor *= 1;
		valorF += valor;
		printf("\nInsira o id: ");
		scanf("%i", &id);
	}
	if (valorF > 0)
		printf("Pagar: R$%.2f", valorF);
}