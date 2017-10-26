#include<stdio.h>
void main(void){
	int entrada, h, m, s, saida;
	printf("Insira os segundos: ");
	scanf("%i",&entrada);
	s = entrada % 60;
	m = entrada / 60 % 60;
	h = entrada / 60 / 60;
	saida = h * 10000 + m * 100 + s;
	printf("A saida em hh mm ss %i" , saida);
}