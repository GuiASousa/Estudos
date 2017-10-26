#include<stdio.h>
void main(void){
	float saldoM, credito;
	printf("Insira o Saldo Medio: ");
	scanf("%i",&saldoM);
	credito = 0;
	if (saldoM <2000)
		credito = 0.1 * saldoM;
	if (saldoM <3000)
		credito = 0.2 * saldoM;
	if (saldoM <4000)
		credito = 0.25 * saldoM;
	printf("Com %.2f de saldo, seu credito eh: %.2f", saldoM, credito);
}