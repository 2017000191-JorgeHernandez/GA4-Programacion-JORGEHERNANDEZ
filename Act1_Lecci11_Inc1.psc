Algoritmo Act1_Lecci11_Inc1
	Definir cupos, contador Como Entero
	Escribir "PARQUEO GRATIS ZONA 1"
	Escribir "---------------------"
	cupos = 0
	
	Repetir 
		Escribir "Presione cualquier tecla para saber cuántos cupos quedan."
		Escribir "--------------------------------------------------------"
		cupos = 200 - Aleatorio(1, 250)
		Esperar Tecla
		Si (cupos <= 0) Entonces
			Escribir "Lamentablemente ya no quedan cupos disponibles."
		SiNo
			Escribir "Quedan ", cupos, " cupos disponibles todavía."
		FinSi
		
		Escribir "Presione cualquier tecla para actualizar la información."
		Esperar Tecla
		Limpiar Pantalla
	Hasta Que (cupos <= 0) 
	
FinAlgoritmo