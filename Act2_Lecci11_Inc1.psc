Algoritmo Act2_Lecci11_Inc1
	Definir num, factorial, i Como Entero
	
	Escribir "Ingrese un numero entero:"
	Leer num
	
	factorial <- 1
	i <- 1
	
	Repetir
		factorial <- factorial * i
		i <- i + 1
	Hasta Que i > num
	
	Escribir "El factorial de ", num, " es: ", factorial
FinAlgoritmo
