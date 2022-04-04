programa {
	funcao inicio() {
	    
		inteiro anos, meses, dias, diasContados
		
		escreva("Quantos anos você tem?")
		leia(anos)
		escreva("E meses?")
		leia(meses)
		escreva("E dias?")
		leia(dias)
		

		diasContados = (anos*365) + (meses*30) + dias
		escreva("Sua idade expressa em dias é: ", diasContados )
	}
}
