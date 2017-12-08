#include <stdio.h>

void dobro(void)
{
	int numero, dobro;
	
	printf("\nDigite um numero inteiro: ");
	scanf("%i",&numero);
	dobro = numero * 2;
	printf("Dobro: %i", dobro);
}

float calcdesconto(float vc)
{	
	if(vc >= 800)
		return 0.15 * vc;
	else
		return 0;	
}

void venda(void)
{
	int codigo, qtdeVendas;
	float precUnit, valComp, valPagar;
	
	printf("\nDigite o codigo do produto: ");
	scanf("%i", &codigo);
	printf("\nDigite o preco unitario: ");
	scanf("%f", &precUnit);
	printf("\nDigite a quantidade vendida: ");
	scanf("%i", &qtdeVendas);
	valComp = qtdeVendas * precUnit;
	valPagar = valComp - calcdesconto(valComp);
	
	printf("\n\nValor da compra: %.2f\nValor do Desconto: %.2f\nValor a pagar: %.2f", valComp, calcdesconto(valComp), valPagar);
}

float calcmedia(float p1, float p2)
{
	return (p1 + p2)/2;
}

void media(void)
{
	int codigo;
	float prv1, prv2;
	
	printf("\nDigite o codigo do aluno: ");
	scanf("%i", &codigo);
	while(codigo > 0)
	{
		printf("\nDigite a nota da primeira prova: ");
		scanf("%f", &prv1);
		printf("\nDigite a nota da segunda prova: ");
		scanf("%f", &prv2);
		printf("\nMedia do aluno: %.1f", calcmedia(prv1,prv2));
		if(calcmedia(prv1,prv2) >= 5)
			printf("\nO aluno esta aprovado");
		else
			printf("\nO aluno esta reprovado");
		
		printf("\nDigite o codigo do aluno: ");
		scanf("%f", &codigo);
	}
}

void tabuada(int F, int Q)
{
	int c,result;
	
	for(c=1;c<=Q;c++)
	{
		result = F * c;
		printf("\n%i x %i = %i",F, c, result);
	}
}
void main(void)
{
   int Opcao, Numero, QtdeElem;    
   
   do{
        printf("\n\nDigite:");
        printf("\n\n1 - Dobro do Numero");
        printf("\n2 - Venda do Produto");
        printf("\n3 - Media do Aluno");
        printf("\n4 - Tabuada");
        printf("\n5 - Sair");
		printf("\n\nOpcao => ");
		scanf("%i", &Opcao);
		
		if(Opcao == 1)
			dobro();
		else if(Opcao == 2)
			venda();
		else if(Opcao == 3)
			media();
		else if(Opcao == 4)
		{
			printf("Insira o numero: ");
			scanf("%i", &Numero);
			printf("Insira a quantidade de elementos: ");
			scanf("%i", &QtdeElem);
			tabuada(Numero, QtdeElem);
		}
   } while (Opcao < 5);
}