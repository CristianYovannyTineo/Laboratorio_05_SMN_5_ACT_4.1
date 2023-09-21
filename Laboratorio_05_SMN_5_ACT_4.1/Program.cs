// See https://aka.ms/new-console-template for more information

//Crear un programa que dado un número máximo muestre 3 opciones:
//1. La primera opción que permita mostrar una lista de números pares
//2. La segunda opción debe permitir mostrar los números impares
//3. La última opción debe permitir mostrar el factorial.

Console.Write("Ingrese el numero limite: ");
if (!int.TryParse(Console.ReadLine(), out int numeroLimite) || numeroLimite <= 0)
    return;
while (true)
{
    Console.WriteLine("===========================");
    Console.WriteLine();
    Console.WriteLine("Escoja un opcion:");
    Console.WriteLine("1: Numeros Pares");
    Console.WriteLine("2: Numeros Impares");
    Console.WriteLine("3: Factorial");
    Console.Write("->");

    if (!int.TryParse(Console.ReadLine(), out int opcion))
    {
        Console.WriteLine("Opcion invalida");
        continue;
    }
    switch (opcion)
    {
        case 1:
            Pares(numeroLimite);
            break;
        case 2:
            Impares(numeroLimite);
            break;
        case 3:
            Factorial(numeroLimite);
            break;
    }
}
static void Pares(int max)
{

    Console.WriteLine("Números pares");
    for (int i = 2; i <= max; i += 2)
        Console.Write(i + ",");
    Console.WriteLine();
}
static void Impares(int max)
{
    Console.WriteLine("Números impares");
    for (int i = 1; i <= max; i += 2)
        Console.Write(i + ",");
    Console.WriteLine();
}
static void Factorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
        factorial *= i;
    Console.WriteLine($"El factorial es {factorial}");
}