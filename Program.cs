namespace SistemadeEvaluacióndeLógicayEstructurasdeDatos;

class Operaciones
{
    public static void SUMATORIA()
    {
        Console.WriteLine("Ingrese dos números para hacerles la suma");

        Console.WriteLine("Ingrese el primer número:");
        int.TryParse(Console.ReadLine(), out int numb1);

        Console.WriteLine("Ingrese el segundo número:");
        int.TryParse(Console.ReadLine(), out int numb2);

        if (numb1 == 0 || numb2 == 0)
        {
            Console.WriteLine("Eso no es un número válido");
        }
        else
        {
            Console.WriteLine("Este es el resultado:");
            Console.WriteLine(numb1 + numb2);
        }
    }
}




class calificaciones
{
    public static void calificacion()
    
        {
            Console.WriteLine("ingrese el primer nota");
            double numb1 = double.Parse(Console.ReadLine());
    
            Console.WriteLine("ingrese la segunda nota");
            double numb2 = double.Parse(Console.ReadLine());
    
            Console.WriteLine("ingrese la tercer nota");
            double numb3 = double.Parse(Console.ReadLine());
    
    
            double promedio = (numb1 + numb2 + numb3) / 3;
            Console.WriteLine("el resultado es"  + promedio);
    
    
        }
    
}

class data
{
    public static void pedir_datos()

    {
        Console.WriteLine("dame el nombre ");
        string nombre = Console.ReadLine();
        Console.WriteLine("dame el apellido ");
        string apellido = Console.ReadLine();

        Console.WriteLine("buenas tu nombre es {1} y tu apellido es {0}", apellido, nombre);
    }
}


class calculos
{
    public static void calculo()
    {
        {
            Console.WriteLine("\n¿Qué quieres hacer?");
            Console.WriteLine("1. sumar");
            Console.WriteLine("2. restar");
            Console.WriteLine("3. multiplicar");
            Console.WriteLine("3. dividir");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                {
                    Console.WriteLine("Sumar");
                    Console.WriteLine("dame un numero");
                    double numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame un el segundo numero");
                    double numero2 = double.Parse(Console.ReadLine());
                    double resultado = numero1 + numero2;
                    Console.WriteLine("el resultado de tu suma es");
                    Console.WriteLine(resultado);
                    break;
                }
                    ;
                case "2":
                {
                    Console.WriteLine("restar");
                    Console.WriteLine("dame un numero");
                    double numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame un el segundo numero");
                    double numero2 = double.Parse(Console.ReadLine());
                    double resultado = numero1 - numero2;
                    Console.WriteLine("el resultado de tu resta es");
                    Console.WriteLine(resultado);
                    break;
                }
                    ;
                case "3":
                {
                    Console.WriteLine("multiplicar");
                    Console.WriteLine("dame un numero");
                    double numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame un el segundo numero");
                    double numero2 = double.Parse(Console.ReadLine());
                    double resultado = numero1 * numero2;
                    Console.WriteLine("el resultado de tu multiplicacion es");
                    Console.WriteLine(resultado);
                    break;
                }
                    ;
                case "4":
                {
                    Console.WriteLine("division");
                    Console.WriteLine("dame un numero");
                    double numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("dame un el segundo numero");
                    double numero2 = double.Parse(Console.ReadLine());

                    if (numero1 == 0 && numero2 == 0)
                    {
                        Console.WriteLine("debe volver a poner un numero por que pusiste 0 y 0 da error");
                    }
                    else
                    {
                        double resultado = numero1 / numero2;
                        Console.WriteLine("el resultado de tu divion es");
                        Console.WriteLine(resultado);
                    }

                    break;

                }
            }
        }
    }
}









class analisis
{
    public static void analizando()
    {
        {

            List<int> numeros = new List<int>();
            {
                for (int numero = 1; numero <= 5; numero++)
                {
                    Console.WriteLine("dame los numeros para calcular son 5");
                    string entrada = Console.ReadLine();

                    if (int.TryParse(entrada, out int num))
                    {
                        numeros.Add(num);
                    }
                    else
                    {
                        Console.WriteLine("numero invalido");
                        numeros.Add(0);
                    }

                }

                int suma = 0;
                int mayor = numeros[0];
                int menor = numeros[0];

                foreach (int num in numeros)
                {
                    suma = suma + num;
                    if (num > mayor)
                    {
                        mayor = num;
                    }

                    if (num < menor)
                    {
                        menor = num;
                    }

                }

                Console.WriteLine(suma);
                Console.WriteLine(mayor);
                Console.WriteLine(menor);


            }
        }
    }
}



class gestion
{
    public static void tarea()
    {
        {
    List<string> tarea = new List<string>();
    bool activacion = true;

    while (activacion) {
        
    
    Console.WriteLine("Gestion tarea");
    Console.WriteLine("---------------");
    Console.WriteLine("1.agregar tarea");
    Console.WriteLine("---------------");
    Console.WriteLine("2.ver tarea");
    Console.WriteLine("---------------");
    Console.WriteLine("3.eliminar tarea");
    Console.WriteLine("---------------");
    Console.WriteLine("4.salir");
    string eleccion = Console.ReadLine();

    switch (eleccion)
    {
        case "1":
        {
            Console.WriteLine("iniciar tarea");
            string nuevasTarea = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nuevasTarea))
            {
                tarea.Add(nuevasTarea);
                Console.WriteLine("Tarea agregado");
            }
            else
            {
                Console.WriteLine("Tarea no encontrado");
            }

            break;
        }
        case "2":
        {
            if (tarea.Count == 0)
            {
                Console.WriteLine("No hay ninguna tarea");
            }
            else
            {
                Console.WriteLine("--- tareas pendientes ----");
                for (int i = 0; i < tarea.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarea[i]}");
                }
            }
            break;
        }
        case "3":
        {
            Console.Write("ingresa el indice de la tarea eliminar");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result) && result > 0 && result < tarea.Count)
            {
                tarea.RemoveAt(result);
                Console.WriteLine("Tarea eliminado");
                
            }
            else
            {
                Console.WriteLine("Tarea no encontrado");
                Console.WriteLine("indice no encontrado");
                
            }
            break;
        }
        case "4":
        {
            activacion = false;
            Console.WriteLine("saliendo del menu del tarea");
            break;
        }
        default:
            Console.WriteLine("opcion invalido");
            break;
    }
    }
}
    }
}







class busqueda
{
    public static void ciudad()
    {
        {
            Console.WriteLine("busqueda de ciudad : ");
            string[] ciudades = { "bogota", "cali", "salvador", "medellin", "santa" };
            Console.WriteLine("ciudad disponibles : " + string.Join(",", ciudades));
            Console.Write("ingresa el nombre de una ciudad para buscar : ");
            string nombre = Console.ReadLine();
            bool encontrado = false;

            foreach (string ciudad in ciudades)
            {
                if (ciudad.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break;
                }
            }
            if(encontrado)
                Console.WriteLine("ciudad: encontrado {0}", nombre );
            else
            {
                Console.WriteLine("ciudad: no hay ciudad");
        
            }
    
        }
    }
}

class collecion
{
    public static void estudiante()
    {
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            bool activacion = true;
            while (activacion)
            {
                Console.WriteLine("-----menu estudiante ---");
                Console.WriteLine("1. registro de estudiante ---");
                Console.WriteLine("2. mostrar estudiante ---");
                Console.WriteLine("3. eliminar estudiante---");
                Console.WriteLine("4. salir---");
                string eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "1":
                    {
                        Console.WriteLine("ingresa el nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("ingresa la edad");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el promedio");
                        double.TryParse(Console.ReadLine(), out double promedio);
                        estudiantes.Add(new Estudiante(nombre, edad, promedio));
                        Console.WriteLine("estudiante registrado");
                        break;
                    }
                    case "2":
                    {
                        if (estudiantes.Count == 0) // ✅ Bug 1 corregido
                        {
                            Console.WriteLine("no hay estudiante");
                        }
                        else
                        {
                            Console.WriteLine("---lista de estudiantes---");
                            for (int i = 0; i < estudiantes.Count; i++)
                            {
                                Console.Write($"{i}. ");
                                estudiantes[i].mostrarInformacion();
                            }
                        }

                        break;
                    }
                    case "3":
                    {
                        Console.Write("ingresa el indice a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 &&
                            indice < estudiantes.Count) // ✅ Bug 3 corregido
                        {
                            estudiantes.RemoveAt(indice);
                            Console.WriteLine("estudiante eliminado");
                        }
                        else
                        {
                            Console.WriteLine("no hay indice valido");
                        }

                        break;
                    }
                    case "4":
                    {
                        activacion = false;
                        Console.WriteLine("saliendo");
                        break;
                    }
                    default:
                        Console.WriteLine("opcion invalida");
                        break;
                }
            }
        }
    }
}



public class Estudiante
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public double promedio { get; set; }

    public Estudiante(string nombre, int edad, double promedio)
    {
        this.nombre = nombre;  
        this.edad = edad;
        this.promedio = promedio;
    }

    public void mostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}, edad: {1}, promedio: {2}", nombre, edad, promedio);
      }
  }