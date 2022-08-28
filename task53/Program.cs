/*Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет
местами первую и последнюю строку массива.
*/


int[,] GetArray(int rows, int columns,int minRandomValue, int maxRandomValue)
{
    int[,] array = new int[rows,columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(minRandomValue,maxRandomValue + 1);
        }
    }
    return array;
}

void CoupInArray(int[,] array)
{
    int temp = 0;
    int j = 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i,j];
        array[i,j] = array[array.Length -i-1,j];
        array[array.Length -1 - i,j];
    }
}

void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " "); 
        }
        System.Console.WriteLine();
    }
    
}

int[,] array = GetArray(3,4,5,8);

PrintArray(array);