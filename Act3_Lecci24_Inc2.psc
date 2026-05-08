Algoritmo Act3_Lecci24_Inc2
	Definir num, suma Como Entero
	
	Escribir "Ingrese un numero:"
	Leer num
	
	suma <- 0
	
	Repetir
		
		Escribir num
		suma <- suma + num
		
		num <- num - 1
		
	Hasta Que num < 1
	
	Escribir "La suma total es: ", suma
FinAlgoritmo
