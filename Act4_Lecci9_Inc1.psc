Algoritmo Act4_Lecci9_Inc1
	Definir num Como Entero
	num = 1
	
	Escribir "TABLAS DE MULTIPLICAR"
	Escribir "No se aceptan números menores que 1"
	Escribir ""
	
	Mientras (num > 0) Hacer
		Escribir "Dime un número y te diré su tabla"
		Escribir "Número: " Sin Saltar
		Leer num
		
		Si (num <= 0) Entonces
			Escribir "ERROR"
			num = 1
		SiNo
			Para i = 1 Hasta 10 Con Paso 1 Hacer
				Escribir num, " x ", i, " = ", num * i
			FinPara
		FinSi
		
	FinMientras
FinAlgoritmo
