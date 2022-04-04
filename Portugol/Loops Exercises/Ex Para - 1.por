programa {
    
    //a) média do salário da população;
    //b) média do número de filhos;
    //c) maior salário;
    //d) percentual de pessoas com salário até R$100,00.
    
	funcao inicio() {
	    
		real  entrevistados[4][2]
		real salario_entrevistado = 0, media_salarios = 0, maior_salario = 0, abaixo_centena= 0, media_filhos = 0
		inteiro filhos_entrevistado
		
		//leitura de dados dos entrevistados
		
		para (inteiro i = 0; i < 4; i++)
		{
		    para(inteiro j = 0; j < 2; j++)
		    {
		        
		        se(j==0)
		        {
		            escreva("Insira o salario do entrevistado " + (i+1) + " : ")
		            leia(salario_entrevistado)
		            entrevistados[i][j] = salario_entrevistado
		        }
		        senao se(j==1)
		        {
		            escreva("Insira o numero de filhos do entrevistado " + (i+1) + ": ")
		            leia(filhos_entrevistado)
		            entrevistados[i][j] = filhos_entrevistado
		            escreva("\n")
		        }
		    }
		}
		    
		    // calcular media de salario
		    
		    para(inteiro k = 0; k < 4; k++)
		    {
		        media_salarios += entrevistados[k][0]
		    }
		    media_salarios = media_salarios/4
		    
		    // calcular media de numero de filhos
		    
		    para(inteiro l = 0; l < 4; l++)
		    {
		        media_filhos += entrevistados[l][1]
		    }
		    media_filhos = media_filhos/4
		    
		    // calcular maior salario
		    
		    para(inteiro m = 0; m < 4; m++)
		    {
		        se(entrevistados[m][0] > maior_salario){
		            maior_salario = entrevistados[m][0]
		        }
		    }
		    
		    // calcular porcentagem dos que recebem menos que R$100
		    
		    para(inteiro n = 0; n < 4; n++)
		    {
		        se(entrevistados[n][0] <= 100){
		            abaixo_centena++
		        }
		    }
		    abaixo_centena = abaixo_centena/4
		    
		    
		    // exibir todos os dados dos entrevistados
		    para(inteiro o = 0; o < 4; o++)
		    {   
		        escreva("Codigo do entrevistado: " + (o + 1) + "\n"
		              + "Salario (R$): " + entrevistados[o][0] + "\n"
		              + "Numero de filhos: " + entrevistados[o][1] + "\n\n")
		    }
		    
		    // exibir resultados da pesquisa
		    
			escreva( "\n\n" + "A media dos salarios foi: " + media_salarios + "\n" + "A media de numero de filhos foi: " + media_filhos + "\n" + "O maior salario foi: R%" + maior_salario + "\n" + "Percentual de pessoas que recebem menos que R$100: " + (abaixo_centena*100) + "%")
	}
}
