programa {
    
    //2- Desenvolver um sistema que efetue a soma de todos os n�meros �mpares que s�o
    //m�ltiplos de tr�s e que se encontram no conjunto dos n�meros de 1 at� 500.

	funcao inicio() {
	    
	    inteiro soma = 0
	    
	    para(inteiro i = 0 ; i <=500 ; i++ )
	    {
	        se(((i % 2) == 1) e ((i % 3) == 0))
	        {
	            soma += i
	        }
	    }
	    
	    escreva("A soma dos numeros impares multiplos de 3 ate 500 �: " + soma)
	}
}
