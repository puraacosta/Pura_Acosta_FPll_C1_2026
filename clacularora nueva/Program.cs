using System;

class program
{ static void  Main()
    {  Console. WriteLine("=== CALCULADORA BASICA");


        Console.Write("Ingrese el primer numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Ingrese el segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSeleccione la operacion:");

        
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");

        Console.Write("Opcion: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;

        switch (opcion)

        { 

            case 1:
                resultado = num1 + num2;
                break;

                case 2:
                resultado = num1 - num2;
                break;

                case 3:
                resultado = num1 * num2;
                break;

                case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    return;
                }

                break;

                default:

                Console.WriteLine("Opcion no valida.");
                return;

        }

        Console.WriteLine($"\nEl resultado es: {resultado}");

    }

}

