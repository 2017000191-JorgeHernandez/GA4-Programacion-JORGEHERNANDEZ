Algoritmo Act3_Lecci15_Inc1	
	Definir num, contador, suma, cantidadPares Como Entero
	
	contador <- 1
	suma <- 0
	cantidadPares <- 0
	
	Repetir
		
		num <- contador * 7
		suma <- suma + num
		
		Si num MOD 2 = 0 Entonces
			cantidadPares <- cantidadPares + 1
		FinSi
		
		contador <- contador + 1
		
	Hasta Que contador > 20
	
	Escribir "La suma de los primeros 20 multiplos de 7 es: ", suma
	Escribir "Cantidad de numeros pares: ", cantidadPares
	
FinAlgoritmo
