using System;

class program
{ static void  Main()
    {  Console. WriteLine("=== BIENVENIDO A LA LOTERIA");

        Console.Writeline("Adivina el numero ganador (1 al 10)\n");)

        // Generar un numero aleatorio entre 1 y 10
        Random random = new Random();
        int numeroGanador = random.Next(1, 11); // 1 al 10

        // Solicitar al usuario que ingrese su numero
        Console.Write("Ingrese su numero: ");

        int numeroUsuario = Convert.ToInt32(Console.ReadLine());

        // Verificar si el numero del usuario es igual al numero ganador
        if (numeroUsuario == numeroGanador)
        {
            Console.WriteLine("¡Felicidades! Has ganado la loteria.");
        }
        else
        {
            Console.WriteLine($"Lo siento, el numero ganador era {numeroGanador}. ¡Intenta de nuevo!");
        }