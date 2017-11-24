#include <stdio.h>
#include <conio.h>
void main (void)
{
	char letras[50];
	int cont, QtdeA, QtdeE, QtdeI, QtdeO, QtdeU;
	QtdeA = 0;
	QtdeE = 0;
	QtdeI = 0;
	QtdeO = 0;
	QtdeU = 0;
	for(cont=0;cont<=49;cont++)
	{
		printf("\nInsira o caracter: ");
		letras[cont] = getche();
		if(letras[cont] == 'a' || letras[cont] == 'A')
			QtdeA++;
		if(letras[cont] == 'e' || letras[cont] == 'E')
			QtdeE++;
		if(letras[cont] == 'i' || letras[cont] == 'I')
			QtdeI++;		
		if(letras[cont] == 'o' || letras[cont] == 'O')
			QtdeO++;
		if(letras[cont] == 'u' || letras[cont] == 'U')
			QtdeU++;
	}
	printf("\nA: %i, E: %i, I: %i, O: %i, U: %i", QtdeA,QtdeE,QtdeI,QtdeO,QtdeU);
}