using SistemadeEvaluacióndeLógicayEstructurasdeDatos;
using System;



while (true)
{
    Console.WriteLine("--- Centro de Entrenamiento Técnico ---");
    Console.WriteLine("1. Nivel 1: Suma y validación numérica");
    Console.WriteLine("2. Nivel 2: Cálculo y condicionales");
    Console.WriteLine("3. Nivel 3: Manipulación de Cadenas");
    Console.WriteLine("4. Nivel 4: Operaciones Lógicas (Calculadora)");
    Console.WriteLine("5. Nivel 5: Análisis Numérico (Listas de enteros)");
    Console.WriteLine("6. Nivel 6: Gestión de Tareas (Listas de cadenas)");
    Console.WriteLine("7. Nivel 7: Arreglos y Búsqueda");
    Console.WriteLine("8. Nivel 8: Programación Orientada a Objetos (Clases)");
    Console.WriteLine("9. Nivel 9: CRUD de Objetos (Listas de objetos)");
    Console.WriteLine("10. Salir");
    Console.Write("Seleccione un nivel para iniciar: ");
    string opciones = Console.ReadLine();
    switch (opciones)
    {
        case "1":
            Operaciones.SUMATORIA();
            break;
        case "2":
            calculos.calculo();
            break;
        case "3":
            // Manipulación de Cadenas
            break;
        case "4":
            // Calculadora
            break;
        case "5":
            analisis.analizando();
            break;
        case "6":
            gestion.tarea();
            break;
        case "7":
            busqueda.ciudad();
            break;
        case "8":
            // data.pedir_datos(); — comentado aún
            break;
        case "9":
            collecion.estudiante();
            break;
        case "10":
            Console.WriteLine("Saliendo...");
            return;
        default:
            Console.WriteLine("Opción no válida. Intente de nuevo.");
            break;
    }
}