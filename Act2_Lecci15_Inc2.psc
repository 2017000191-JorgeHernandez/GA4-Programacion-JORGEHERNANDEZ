Algoritmo Act2_Lecci15_Inc2
	Definir billete, cantidad100, total100 Como Entero
	
	cantidad100 <- 0
	total100 <- 0
	
	Escribir "Ingrese los billetes."
	Escribir "Para terminar escriba 0."
	
	Repetir
		
		Leer billete
		
		Si billete = 100 Entonces
			cantidad100 <- cantidad100 + 1
			total100 <- total100 + 100
		FinSi
		
	Hasta Que billete = 0
	
	Escribir "Cantidad de billetes de 100: ", cantidad100
	Escribir "Total de dinero en billetes de 100: $", total100
	
FinAlgoritmo
