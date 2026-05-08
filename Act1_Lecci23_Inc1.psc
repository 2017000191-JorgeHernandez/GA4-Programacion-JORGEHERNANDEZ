Algoritmo Act1_Lecci23_Inc1
	
	Definir pesoManzana, pesoTotal Como Real
	Definir cantidad Como Entero
	
	pesoTotal <- 0
	cantidad <- 0
	
	Escribir "Coloque manzanas en la bascula."
	Escribir "El programa termina cuando llegue a 1 kilo o mas."
	
	Repetir
		
		Escribir "Ingrese el peso de la manzana (en kilos):"
		Leer pesoManzana
		
		pesoTotal <- pesoTotal + pesoManzana
		cantidad <- cantidad + 1
		
		Escribir "Peso acumulado: ", pesoTotal, " kg"
		
	Hasta Que pesoTotal >= 1
	
	Escribir "Ya tiene 1 kilo o mas de manzanas."
	Escribir "Cantidad de manzanas: ", cantidad
	Escribir "Peso total: ", pesoTotal, " kg"

FinAlgoritmo
