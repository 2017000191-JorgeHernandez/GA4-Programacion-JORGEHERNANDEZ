Algoritmo Act3_Lecci9_Inc2
	Definir num, i Como Entero
	num = 0
	
	Escribir "NÚMEROS IMPARES DE X NÚMERO A 20"
	
	Mientras (num <= 20) Hacer
		Escribir "Dime un número del 1 al 20"
		Escribir "Número: " Sin Saltar
		Leer num
		
		Si (num % 2 = 0) Entonces
			Para i = num + 1 Hasta 20 Con Paso 2 Hacer
				Escribir i
			FinPara
		Sino
			Para i = num Hasta 20 Con Paso 2 Hacer
				Escribir i
			FinPara
		FinSi
	FinMientras
	
FinAlgoritmo