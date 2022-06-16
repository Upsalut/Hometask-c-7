// Написать программу, которая обменивает элементы первой строки и последней строки
void PrintMatrix(double[,] dMatrix)
{
    for (int i = 0; i < dMatrix.GetLength(0); i++)
    {
        for(int j=0;j < dMatrix.GetLength(1);j++)
            Console.Write($"{dMatrix[i,j]} ");
        Console.WriteLine();
    }   
}      
double[,] GetFilledMatrix(int rows,int columns)
{
    double[,] dMatrix = new double[rows,columns];
    Random    rnd     = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            dMatrix[i,j] = Math.Round(rnd.NextDouble()*10,2);

    return(dMatrix);
}
void ChangeFirstAndLastRows(double[,] dMatrix)
{
    int lastRowIndex = dMatrix.GetLength(0)-1;
    for (int i = 0; i < dMatrix.GetLength(1); i++)
    {
        double tmp = dMatrix[0,i];
        dMatrix[0,i] = dMatrix[lastRowIndex,i];
        dMatrix[lastRowIndex,i] = tmp;
    }
}
Console.Write("Введите количество рядов: ");
int rows    = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите количество колонок: ");
int columns = int.Parse(Console.ReadLine()?? "");

double[,] dMatrix = GetFilledMatrix(rows,columns);
PrintMatrix(dMatrix);
Console.WriteLine();
ChangeFirstAndLastRows(dMatrix);
PrintMatrix(dMatrix);