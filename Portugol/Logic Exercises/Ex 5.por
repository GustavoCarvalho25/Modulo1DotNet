programa {
	funcao inicio() {
	    
		real media, n1, n2, n3
		escreva("Insira a nota 1: ")
		leia(n1)
		escreva("Insira a nota 2: ")
		leia(n2)
		escreva("Insira a nota 3: ")
		leia(n3)
		
		media = ((n1 * 2) + (n2 * 3) + (n3 * 5))/10 
		
		escreva("\n" + "A média ponderada das notas desse aluno é: " + media)

	}
}
