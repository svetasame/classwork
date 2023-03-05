//задача 46
// двумерный массив размера m x n 
// заполненный случайными целыми числами

static int Prompt (string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}


void GenerateTwoArray (int rows, int columns)
{
int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++) 
//стандартный метод лендж не работает на двумерных
{ 
    System.Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j ++)
    {
        matrix [i, j] = new Random().Next(-10,11);
    System.Console.Write(matrix [i, j] + " ");
    }
}
}

void GenerateArrayMplusN (int rows, int columns)
{
int [,] matrix = new int [rows,columns];
for (int i = 0; i < matrix.GetLength(0); i++) 
{ 
    System.Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j ++)
    {
        matrix [i, j] = i+j;
    System.Console.Write(matrix [i, j] + " ");
    }
}
}

// задача 48 2 мерный массив размер м х н 
// каждый элемент по формул а мн = m+n
// вывести на экран
int m = Prompt ("Введите количество строк");
int n = Prompt ("Введите количество столбцов");
GenerateArrayMplusN (m, n);