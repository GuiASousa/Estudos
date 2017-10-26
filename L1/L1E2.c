#include<stdio.h>
void main(void){
	float l1,l2,tela;
	
	printf("Insira o lado 1: ");
	scanf("%f", &l1);
	printf("Insira o lado 2: ");
	scanf("%f", &l2);
	tela = l1 * 2 + l2 * 2;
	printf("A quantidade de tela eh %.2f", tela);
}