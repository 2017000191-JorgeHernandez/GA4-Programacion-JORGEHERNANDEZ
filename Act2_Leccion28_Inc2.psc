Algoritmo Act2_Leccion28_Inc2
	Definir tipo, boletos_ninos, boletos_adultos Como Entero
    Definir total Como Real
    Definir continuar Como Entero
    
    boletos_ninos <- 0
    boletos_adultos <- 0
    total <- 0
    continuar <- 1
    
    Mientras continuar = 1 Hacer
        
        Escribir "Ingrese el tipo de persona:"
        Escribir "1 = Niño"
        Escribir "2 = Adulto"
        Leer tipo
        
        Segun tipo Hacer
            1:
                boletos_ninos <- boletos_ninos + 1
                total <- total + 10
            2:
                boletos_adultos <- boletos_adultos + 1
                total <- total + 15
            De Otro Modo:
                Escribir "Opción inválida"
        FinSegun
        
        Escribir "¿Desea ingresar otra persona? (1 = Sí, 0 = No)"
        Leer continuar
        
    FinMientras
    
    Escribir "---------------------------"
    Escribir "Boletos vendidos:"
    Escribir "Niños: ", boletos_ninos
    Escribir "Adultos: ", boletos_adultos
    Escribir "Total recaudado: $", total
    Escribir "---------------------------"
	
FinAlgoritmo
