using System;

class Program
{
    static void Main()
    {
        string nombre = "";
        string apellido = "";
        int edad = 0;
        char sexo = ' ';
        DateTime fechaNacimiento = DateTime.MinValue;
        bool tieneLicencia = false;

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Agregar nombre");
            Console.WriteLine("2. Agregar apellido");
            Console.WriteLine("3. Agregar edad");
            Console.WriteLine("4. Agregar sexo");
            Console.WriteLine("5. Agregar fecha de nacimiento");
            Console.WriteLine("6. Agregar licencia de conducir");
            Console.WriteLine("7. Mostrar datos del empleado");
            Console.WriteLine("8. Salir");

            Console.Write("Ingrese una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el nombre: ");
                    nombre = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Ingrese el apellido: ");
                    apellido = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("Ingrese la edad: ");
                    int.TryParse(Console.ReadLine(), out edad);
                    break;
                case "4":
                    Console.Write("Ingrese el sexo (F/M): ");
                    char.TryParse(Console.ReadLine(), out sexo);
                    break;
                case "5":
                    Console.Write("Ingrese la fecha de nacimiento (dd/mm/aaaa): ");
                    DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);
                    break;
                case "6":
                    Console.Write("¿Posee licencia de conducir? (S/N): ");
                    string respuestaLicencia = Console.ReadLine();
                    tieneLicencia = respuestaLicencia.ToLower() == "s";
                    break;
                case "7":
                    Console.WriteLine("Datos del empleado:");
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Apellido: " + apellido);
                    Console.WriteLine("Edad: " + edad);
                    Console.WriteLine("Sexo: " + sexo);
                    Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento.ToString("dd/MM/yyyy"));
                    Console.WriteLine("Licencia de conducir: " + (tieneLicencia ? "Sí" : "No"));
                    break;
                case "8":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
