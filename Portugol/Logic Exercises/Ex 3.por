programa {
	funcao inicio() {
	    
		inteiro horas, minutos, segundos
		escreva("Qual a dura��o do evento em segundos?")
		leia(segundos)
		
		horas = segundos/3600
		minutos = (segundos%3600)/60
		segundos = (segundos%3600)%60
		escreva("A dura��o do evento em horas, minutos e segundos �:", "\n","Horas: ",horas, "\n", "Minutos: ", minutos, "\n", "Segundos: ", segundos )

	}
}
