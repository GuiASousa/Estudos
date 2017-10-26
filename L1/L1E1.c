#include<stdio.h>
void main(void){
	int quantidade;
	float preco, valorCompra;
	
	printf("Digite o preco unitario: ");
	scanf("%f", &preco);
	printf("Digite a quantidade: ");
	scanf("%i", &quantidade);
	valorCompra = preco * quantidade;
	printf("O valor da compra eh R$%.2f", valorCompra);
}