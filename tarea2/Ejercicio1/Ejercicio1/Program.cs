// See https://aka.ms/new-console-template for more information
//Ejercicio 1

int[,] matriz = new int[3, 3];

int result = 0;
int val = 1;
int sum = 0;
Random rand = new Random();

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matriz[i, j] = val++;
        if (j >= i)
        {
            sum += matriz[i, j]; //acumulador

        }
        result = sum - 6;

        Console.Write($"    {matriz[i, j]}");
    }
    Console.WriteLine();
}
Console.WriteLine("La suma es igual a: " + result);
