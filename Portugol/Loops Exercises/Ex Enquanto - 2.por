programa {
    
    //2- Obtenha um número digitado pelo usuário e repita a operação de multiplicar ele por três
    //(imprimindo o novo valor) até que ele seja maior do que 100. Ex.: se o usuário digita 5,
    //deveremos observar na tela a seguinte sequência: 5 15 45 135.

	funcao inicio() {
		inteiro n = 0, mult_tres = 0
		
		escreva("Insira um numero inteiro: ")
		leia(n)
		mult_tres = n
		
		enquanto(n<=100)
		{
		    escreva(mult_tres + " ")
		    n = mult_tres
		    mult_tres = (n * 3)
		}
	}
}
