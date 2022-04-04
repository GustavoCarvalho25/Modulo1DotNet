programa {
	funcao inicio() {
	    
	    real valor, soma = 0, contador = 0, media = 0
	    
		escreva("Insira um valor positivo para somar à cadeia ou um negativo para interromper: ")
		leia(valor)
		contador++
		se(valor >= 0)
		{
		    enquanto(valor >= 0 )
		    {   
		        contador++
		        soma += valor
		        escreva(soma)
		        escreva("Insira um valor positivo para somar à cadeia ou um negativo para interromper: ")
		        leia(valor)
		        
		    }
		    media = (soma/contador)
		    
		}
		senao
		{
		   escreva("Valor invalido!")
		}
		escreva("\n" + "O resultado da soma dos valores inseridos foi: " + soma + "\n" + "A quantidade de valores inseridos foi: " + contador + "\n" + "A media desses valores foi: " + media)
		
	}
}
