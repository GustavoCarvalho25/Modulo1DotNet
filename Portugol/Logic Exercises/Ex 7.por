programa {
    
    inclua biblioteca Matematica --> mat
    
	funcao inicio() {
	    
	    real A, B, C, D, E, F, x, y
	    
		escreva("Insira o coeficiente A: ")
		leia(A)
        escreva("Insira o coeficiente B: ")
		leia(B)
		escreva("Insira o coeficiente C: ")
		leia(C)
		escreva("Insira o coeficiente D: ")
		leia(D)
		escreva("Insira o coeficiente E: ")
		leia(E)
		escreva("Insira o coeficiente F: ")
		leia(F)
		
		x = ((C * E) - (B * F))/((A * E) - (B * D))
		y = ((A * F) - (C * D))/((A * E) - (B * D))
		
		escreva("\n" + "Os valores são:" + "\n" + "X: " + x + "\n" + "Y: " + y)
		
	}
}
