programa {
    
    //2- Obtenha um n�mero digitado pelo usu�rio e repita a opera��o de multiplicar ele por tr�s
    //(imprimindo o novo valor) at� que ele seja maior do que 100. Ex.: se o usu�rio digita 5,
    //deveremos observar na tela a seguinte sequ�ncia: 5 15 45 135.

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
