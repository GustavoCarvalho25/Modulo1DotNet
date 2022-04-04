programa {
    
    inclua biblioteca Matematica --> mat
    
	funcao inicio() {
	    
	    real x1, y1, x2, y2, d
	    
		escreva("Insira a coordenada X do Ponto 1: ")
		leia(x1)
        escreva("Insira a coordenada Y do Ponto 1: ")
		leia(y1)
		escreva("Insira a coordenada X do Ponto 2: ")
		leia(x2)
		escreva("Insira a coordenada Y do Ponto 2: ")
		leia(y2)
		
		d = mat.raiz(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)), 2.0)
		escreva("\n" + "A distância é: " + d)
		
	}
}
