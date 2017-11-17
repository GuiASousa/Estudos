#include<stdio.h>
#include<conio.h>
void main(void){
	char tipo;
	float valor, valorF;
	int id;
	valorF = 0
	printf("Insira o id");
	scanf("%i", &id);
	while(id>0)
	{
		printf("Insira o valor");
		scanf("%f", &valor);
		printf("Insira o tipo");
		getche();
		if(tipo == 'E' || tipo == 'e')
			valor *= 0.75;
		if(tipo == 'I' || tipo == 'i')
			valor *= 0.65
		valorF += valor;
		printf("Insira o id");
		scanf("%i", &id);
	}
	if (valorF > 0)
		printf("%i", valorF);
}