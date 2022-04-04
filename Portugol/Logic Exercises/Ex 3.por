programa {
	funcao inicio() {
	    
		inteiro horas, minutos, segundos
		escreva("Qual a duração do evento em segundos?")
		leia(segundos)
		
		horas = segundos/3600
		minutos = (segundos%3600)/60
		segundos = (segundos%3600)%60
		escreva("A duração do evento em horas, minutos e segundos é:", "\n","Horas: ",horas, "\n", "Minutos: ", minutos, "\n", "Segundos: ", segundos )

	}
}
