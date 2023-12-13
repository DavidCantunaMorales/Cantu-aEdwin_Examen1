/* Ejercicio 3: Programación Orientada a Objetos - Clases y Objetos */

/*
    1. Crea una clase llamada Estudiante con propiedades como Nombre, Edad y
    Calificacion.
    2. Crea un objeto de tipo Estudiante llamado estudiante1 e inicializa sus
    propiedades con valores ficticios.
    3. Imprime en la consola la información del estudiante.
*/

using Ejercicio3;

Estudiante estudiante1 = new Estudiante("David", 21, 16.5);

Console.WriteLine("INFORMACION DEL ESTUDIANTE");
Console.WriteLine($"Nombre: {estudiante1.nombre}");
Console.WriteLine($"Edad: {estudiante1.edad}");
Console.WriteLine($"Calificacion: {estudiante1.calificacion}");
