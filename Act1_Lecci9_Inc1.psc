Algoritmo Act1_Lecci9_Inc1
	Definir pesoAcumulado, pesoManzana, contador Como Real
	pesoAcumulado = 0
	contador = 0
	Escribir "============================="
	Escribir"Báscula del mercado"
	Escribir "============================="
	
	Mientras (pesoAcumulado < 1000) Hacer
		Escribir "Ingresa el peso de la manzana. Límite (100 - 300 gramos): "
		Leer pesoManzana
		
		Si (pesoManzana >= 100 y pesoManzana <= 300) Entonces
			pesoAcumulado = pesoAcumulado + pesoManzana
			Escribir "El peso acumulado: ", pesoAcumulado, " gramos"
			
			contador = contador +1
		Sino
			Escribir "ERROR"
		FinSi
	FinMientras
	
	Escribir "1000 gramos alcanzados, ya tiene", pesoAcumulado/1000, " kilos en manzanas."
	Escribir "Total de manzanas: ", contador
FinAlgoritmo