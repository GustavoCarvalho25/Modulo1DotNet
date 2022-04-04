programa {
    
    //1- Faça um programa que mostre uma contagem na tela de 233 a 456, só que contando de
    //3 em 3 quando estiver entre 300 e 400 e de 5 em 5 quando não estiver.
    
	funcao inicio() {
		inteiro contador = 233
		
		escreva("A listagem dos números fica desta maneira:")
		faca
		{
		    escreva("\n" + contador)
		    contador++
		    
		} enquanto (contador < 300)
		faca
		{
		    escreva("\n" + contador)
		    contador += 3
		    
		} enquanto( contador <= 400)
		faca
		{
		    escreva("\n" + contador)
		    contador += 5
		    
		} enquanto(contador <= 456)
	}
}
