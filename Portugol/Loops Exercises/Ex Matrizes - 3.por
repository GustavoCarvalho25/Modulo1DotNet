programa {
    
    //3. O array apresentado é [3, 5, 7, 1, 6]. Encontre qual é o maior número?
    
	funcao inicio() {
		
		inteiro maior = 0, array[] = {3, 5, 7, 1, 6}
		
		para(inteiro i = 0; i < 5; i++)
		{
		    se(maior < array[i])
		    {
		        maior = array[i]
		    }
		}
		
		escreva("O maior numero é: " + maior)
	}
}
