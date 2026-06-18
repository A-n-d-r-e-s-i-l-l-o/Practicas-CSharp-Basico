using System;
using System.Timers;
void GenerarReporteEstudiante(string? estudiante,double nota1,double nota2)
{
    string estado = ((nota1+nota2)/2)>=11? "Aprobado" : "Desaprobado";
    Console.WriteLine($@"Estudiante: {estudiante}
La notas son {nota1} y {nota2}
El promedio es {(nota1+nota2)/2}
El alumno esta {estado}");    
}

Console.Write("Ingrese el nombre del estudiante: ");
string? nombre = Console.ReadLine();
Console.Write("Ingrese la nota 1 del estudiante: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la nota 2 del estudiante: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
GenerarReporteEstudiante(nombre,nota1,nota2);
