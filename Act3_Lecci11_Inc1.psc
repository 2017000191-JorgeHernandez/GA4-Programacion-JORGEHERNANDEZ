Algoritmo Act3_Lecci11_Inc1
	Definir num1, num2, min, max, acumulador, contador Como Entero
	acumulador = 0
	contador = 0
	Escribir "Dime dos números y te dire la suma entre esos números"
	Escribir "Número 1: " Sin Saltar
	Leer num1
	Escribir "Número 2: " Sin Saltar
	Leer num2
	
	Si (num1 > num2) Entonces
		max = num1
		min = num2
		
		contador = num2
	Sino 
		max = num2
		min = num1
		
		contador = num1
	FinSi
	
	Repetir
		acumulador = acumulador + contador
		contador = contador + 1
	Hasta Que (contador > max)
	
	Escribir ""
	Escribir "Resultado : ", acumulador
	
	FinAlgoritmor "La suma de los numeros entre ", menor, " y ", mayor, " es: ", suma
FinAlgoritmo