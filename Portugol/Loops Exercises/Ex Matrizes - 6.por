programa {
    
    //6. O array apresentado � {{34,56},{87,90},{25,58}}. Encontre o menor n�mero?
    
	funcao inicio() {

        inteiro array[3][2] =  {{34,56},{87,90},{25,58}}, menor = array[0][0]
        para(inteiro i = 0; i < 3; i++)
        {
            para(inteiro j = 0; j < 2; j++){
                
                se(menor > array[i][j])
                {
                    menor = array[i][j]
                }
            }
        }
        escreva("O menor numero �: " + menor)
	}
}
