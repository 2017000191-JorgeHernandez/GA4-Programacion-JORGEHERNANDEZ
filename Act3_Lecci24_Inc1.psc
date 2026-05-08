Algoritmo Act3_Lecci24_Inc1
	Definir num, i, suma Como Entero
	Definir esPrimo Como Logico
	
	suma <- 0
	num <- 2
	
	Repetir
		
		esPrimo <- Verdadero
		i <- 2
		
		Repetir
			
			Si num MOD i = 0 Entonces
				esPrimo <- Falso
			FinSi
			
			i <- i + 1
			
		Hasta Que i >= num O esPrimo = Falso
		
		Si esPrimo Entonces
			suma <- suma + num
		FinSi
		
		num <- num + 1
		
	Hasta Que num > 50
	
	Escribir "La suma de los numeros primos entre 1 y 50 es: ", suma
FinAlgoritmo
