Algoritmo Act1_Lecci15_Inc1
	Definir hora1, voletos1, voletos2, acumulador1, acumulador2, hora, total1, total2, resultado1, resultado2 Como Entero
	acumulador1 = 0
	acumulador2 = 0
	total1 = 0
	total2 = 0
	Escribir "REGISTRO DE BOLETOS VENDIDOS Y DINERO RECAUDADO."
	Escribir "Hora de apertura: 8 a.m."
	Escribir "Hora de cierre: 5 a.m."
	Escribir ""
	
	Repetir 
		Escribir "¿Cuántos voletos de adulto va a comprar?"
		Leer voletos1
		Escribir "¿Cuántos voletos de niño va a comprar?"
		Leer voletos2
		Escribir "Hora: "
		Leer hora1
		
		Si (voletos1 >= 1) Entonces
			resultado1 = voletos1 * 15
		FinSi
		Si (voletos2 >= 1) Entonces
			resultado2 = voletos2 * 10
		FinSi
		
		acumulador1 = acumulador1 + voletos1
		acumulador2 = acumulador2 + voletos2
		
		total1 = total + acumulador1 + acumulador2
		total2 = resultado1 + resultado2
	Hasta Que (hora1 >= 1700)
	
	Escribir "Total de voletos: ", total1
	Escribir "Total de dinero: ", total2
FinAlgoritmo