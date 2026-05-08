Algoritmo Act2_Lecci11_Inc2
	Definir num Como Entero
	num = 1
	Escribir "Impares del 1 al 100"
	
	Repetir
		Escribir "-------------------------------------------------------"
		Escribir "Presiona cualquier tecla para ir mostrando los números."
		Esperar Tecla
		Limpiar Pantalla
		Escribir num
		
		num = num + 2
		
	Hasta Que (num > 99)
FinAlgoritmo