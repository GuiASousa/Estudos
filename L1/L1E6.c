#include<stdio.h>
void main(void){
	float salFix, vendas, salFin;
	printf("Insira o salario fixo: ");
	scanf("%f",&salFix);
	printf("Insira as vendas: ");
	scanf("%f",&vendas);
	vendas *= 0.04;
	salFin = vendas + salFix;
	printf("As vendas foram de %.2f e o salario final %.2f", vendas, salFin);
}