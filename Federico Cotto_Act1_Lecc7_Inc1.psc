//un algoritmo que determine si un estudiante ganó o perdió segun el promedio
Algoritmo Act1_Lecc7_Inc1
	Escribir "==:Promedio de calificación:== "
	//variables
	Definir matr Como Caracter
	Definir n1, n2, n3, n4, n5 Como Entero
	Definir promedio Como Real
	
	//solicitar datos al usuario
	Escribir "Escriba la materia: "
	Leer  matr
	Escribir "INgresa tus notas: "
	Leer n1, n2, n3, n4, n5
	
	//Proceso 
	promedio = (n1+n2+n3+n4+n5)/5
	//Evaluar si gano o perdio
	Si promedio >=70 Entonces
		Escribir "Estudiante aprobado con: ",promedio
	SiNo
		Escribir "Estudiante Reprobado con: ",promedio
	Fin Si
	
	
FinAlgoritmo
