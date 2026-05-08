Algoritmo Act2_Lecci10_Inc2
	Definir num, i Como Real
	Escribir "Números pares desde 2 hasta x"
	Escribir "El número tiene que ser mayor a 2"
	Escribir "Dime un número: " Sin Saltar
	Leer num
	
	Si (num >= 2) Entonces
		Para i = 2 Hasta num Con Paso 2 Hacer
			Escribir i
		FinPara
	SiNo
		Escribir "ERROR"
	FinSi
	
FinAlgoritmo
