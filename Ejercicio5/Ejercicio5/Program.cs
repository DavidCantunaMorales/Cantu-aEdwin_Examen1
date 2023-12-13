﻿
/* Ejercicio 5: Programación Orientada a Objetos - Herencia */

/*
    1. Crea una nueva clase llamada EstudianteGraduado que herede de la clase
    Estudiante.
    2. Añade una nueva propiedad a EstudianteGraduado llamada Titulo que
    almacene el título obtenido.
    3. Crea un objeto de tipo EstudianteGraduado llamado graduado1 e inicializa sus
    propiedades.
    4. Utiliza el método MostrarInformacion de la clase base para mostrar la
    información del estudiante graduado.
*/


using Ejercicio5;

EstudianteGraduado graduado1 = new EstudianteGraduado("Maria Jose", 21, 20, "Enfermeria");
Console.WriteLine("Información del Estudiante Graduado:");
graduado1.MostrarInformacion();
Console.WriteLine($"Titulo: {graduado1.titulo}");


