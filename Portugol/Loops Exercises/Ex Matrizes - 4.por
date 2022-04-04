programa {

    //4. O array apresentado é [3, 5, 7, 1, 6]. Encontre qual é o menor número?

    funcao inicio() {

        inteiro array[] = {3, 5, 7, 1, 6}, menor = array[0]

        para(inteiro i = 0; i < 5; i++)
        {
            se(menor > array[i])
            {
                menor = array[i]
            }
        }

        escreva("O menor numero é: " + menor)
    }
}