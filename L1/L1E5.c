#include<stdio.h>
void main(void){
	float peso;
	printf("Insira o peso: ");
	scanf("%f",&peso);
	peso *= 1000;
	printf("Seu peso em gramas eh: %.2f", peso);
}