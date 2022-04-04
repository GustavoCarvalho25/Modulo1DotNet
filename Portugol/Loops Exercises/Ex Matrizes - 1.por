programa {
    
    //1. Considerando um array [1, 2, 4, 5]. O output deve ser [2, 4, 8, 10].
	funcao inicio() {
		
		inteiro array[] = {1, 2, 4, 5}
		
		escreva("[")
		para(inteiro i = 0; i < 4; i++)
		{
		    
		    se(i == 3)
		    {   
		        array[i] = array[i] * 2
		        escreva(array[i] + "]")
		    }
		    senao
		    {
		        array[i] = array[i] * 2
		        escreva(array[i] + ", ")
		    }
		}
	}
}
