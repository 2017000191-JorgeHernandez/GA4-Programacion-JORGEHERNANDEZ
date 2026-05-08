Algoritmo Act2_Lecci9_Inc1
	Definir moneda Como Entero
	moneda = 0
	Escribir "*********************"
	Escribir "¿Pasaste de nivel?"
	Escribir "*********************"
	
	Mientras (moneda < 501) Hacer
		Escribir "Dime cuántas monedas tienes y te diré si pasaste al nivel 5"
		Escribir "Monedas (max. 500): " Sin Saltar
		Leer moneda
		
		Si (moneda <= 350 y moneda >= 0) Entonces
			Escribir "Todavía no has pasado al nivel 5"
		Sino
			Si (moneda >= 351 y moneda <= 500) Entonces
				Escribir "FELICIDADES, HAS PASADO AL NIVEL 5"
			SiNo
				Escribir "ERROR, CANTIDAD NO ACEPTADA"
			FinSi
		FinSi
	FinMientras
FinAlgoritmo
