programa {
	funcao inicio() {
	    
		inteiro a, b, c, r, s, d
		escreva("Insira o valor A: ")
		leia(a)
		escreva("Insira o valor B: ")
		leia(b)
		escreva("Insira o valor C: ")
		leia(c)
		
		r = (a + b) * (a + b)
		s = (b + c) * (b + c)
		d = (r + s)/2
		
		escreva("\n" + "Os valores são:" + "\n" + "R: " + r + "\n" + "S: " + s + "\n" + "D: " + d )

	}
}
