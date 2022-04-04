programa {
	funcao inicio() {
	    
		inteiro anos, meses, dias
		escreva("Qual sua idade expressa em dias?")
		leia(dias)
        anos = dias/365
        meses = (dias % 365)/30
        dias = (dias % 365)%30
		escreva("Sua idade expressa em anos, meses e dias é:", "\n","Anos: ",anos, "\n", "Meses: ", meses, "\n", "Dias: ", dias )
	}
}
