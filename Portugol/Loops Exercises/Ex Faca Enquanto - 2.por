programa {
    
    //2- Fa�a um programa que pegue um n�mero do teclado e calcule a soma de todos os
    //n�meros de 1 at� ele. Ex.: o usu�rio entra 7, o programa vai mostrar 28, pois
    //1+2+3+4+5+6+7=28.
    
	funcao inicio() {
		inteiro valor, soma = 0, contador = 0
		
		escreva("Insira o valor desejado para que a soma de seus anteriores seja calculada: ")
		leia(valor)
		
		faca
		{
		    soma += contador
		    contador++
		    
		} enquanto(contador <= valor)
		
		escreva("\nO valor da soma �: " + soma)
	}
}
