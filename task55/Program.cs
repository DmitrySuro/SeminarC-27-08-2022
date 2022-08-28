/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки
 на столбцы. В случае, если это невозможно, 
 программа должна вывести сообщение для пользователя.
*/

System.Console.Clear();

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


int[,] ReplacedRowsColumnsInArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
return array;
}