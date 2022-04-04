programa {
    
    //2. Considerando um array [1, 2, 3, 4] A soma é 10. O produto é 24.
    
	funcao inicio() {
		
		inteiro array[] = {1, 2, 3, 4}, produto = 1, soma = 0
		
		//calcular a soma
		
		para(inteiro i = 0; i < 4; i++)
		{
		    soma += array[i]
		}
		
		//calcular produto
		
		para(inteiro j = 0; j < 4; j++)
		{
		    produto = produto * array[j]
		    
		}
		
		// Exibir resultados
		
		escreva("O valor da soma dos elementos do array é: " + soma + "\nO valor do produto dos elementos do array é: " + produto)
		
	}
}
