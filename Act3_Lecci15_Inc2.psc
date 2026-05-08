Algoritmo Act3_Lecci15_Inc2
	Definir num, i, contadorPrimos, sumaPares Como Entero
	Definir esPrimo Como Logico
	
	num <- 300
	contadorPrimos <- 0
	sumaPares <- 0
	
	Repetir
		
		Si num MOD 2 = 0 Entonces
			sumaPares <- sumaPares + num
		FinSi
		
		Si num > 1 Entonces
			
			esPrimo <- Verdadero
			i <- 2
			
			Repetir
				
				Si num MOD i = 0 Entonces
					esPrimo <- Falso
				FinSi
				
				i <- i + 1
				
			Hasta Que i >= num O esPrimo = Falso
			
			Si esPrimo Entonces
				contadorPrimos <- contadorPrimos + 1
			FinSi
			
		FinSi
		
		num <- num - 1
		
	Hasta Que num < 1
	
	Escribir "Cantidad de numeros primos entre 300 y 1: ", contadorPrimos
	Escribir "Suma de los numeros pares entre 300 y 1: ", sumaPares
	
FinAlgoritmo
