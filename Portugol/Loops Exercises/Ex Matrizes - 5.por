programa {

    //5. O array apresentado é {{34,56},{87,90},{25,58}}. Encontre o maior número?

    funcao inicio() {

        inteiro maior = 0, array[3][2] =  {{34,56},{87,90},{25,58}}

        para(inteiro i = 0; i < 3; i++)
        {
            para(inteiro j = 0; j < 2; j++){
                
                se(maior < array[i][j])
                {
                    maior = array[i][j]
                }
            }
        }

        escreva("O maior numero é: " + maior)
    }
}