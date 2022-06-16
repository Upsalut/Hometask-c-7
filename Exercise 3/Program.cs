// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
void PrintMatrix(double[,] dMatrix)
{
    for (int i = 0; i < dMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < dMatrix.GetLength(1); j++)
            Console.Write($"{dMatrix[i, j]} ");
        Console.WriteLine();
    }
}

double[,] GetFilledMatrix(int rows, int columns)
{
    double[,] dMatrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            dMatrix[i, j] = Math.Round(rnd.NextDouble() * 10, 2);

    return (dMatrix);
}
double[,] ReverseRowsToColumns(double[,] dMatrix)
{
    double[,] tmpMatrix = new double[dMatrix.GetLength(0),dMatrix.GetLength(1)];
    for (int i = 0; i < dMatrix.GetLength(0); i++)
        for (int j = 0; j < dMatrix.GetLength(1); j++)
            tmpMatrix[j,i] = dMatrix[i,j];
    return(tmpMatrix);        
}
Console.Write("Введите количество рядов: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество колонок: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] dMatrix = GetFilledMatrix(rows, columns);
PrintMatrix(dMatrix);
Console.WriteLine();
Console.WriteLine("Попытка замены строк на столбцы: ");
if(rows!=columns)
{
    Console.WriteLine("Замена строк на столбца не возможна. Матрица не квадратная!!!");
    return;
}
dMatrix = ReverseRowsToColumns(dMatrix);
PrintMatrix(dMatrix);
Console.WriteLine("Попытка успешна.");
