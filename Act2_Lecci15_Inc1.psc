Algoritmo Act2_Lecci15_Inc1
	Definir num, i, contador, suma Como Entero
	Definir esPrimo Como Logico
	
	contador <- 0
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
			contador <- contador + 1
			suma <- suma + num
		FinSi
		
		num <- num + 1
		
	Hasta Que num > 100
	
	Escribir "Cantidad de numeros primos entre 1 y 100: ", contador
	Escribir "La suma de los numeros primos es: ", suma
	
FinAlgoritmo
