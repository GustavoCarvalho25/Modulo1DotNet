programa {
    
    inclua biblioteca Matematica --> mat
    
	funcao inicio() {
	    
	    real precoFab, precoFinal
	    
		escreva("Insira o preço de fábrica do carro desejado: ")
		leia(precoFab)
        precoFinal = (precoFab * 173)/100
        escreva("\n" + "O valor final para o consumidor é: R$ " + precoFinal)
	}
}
