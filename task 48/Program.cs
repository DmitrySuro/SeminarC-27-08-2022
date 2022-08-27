/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
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


string GetStringFromArray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i,j] + " ";
        }
        result += '\n';
    }
    return result;
}



System.Console.WriteLine(
    GetStringFromArray(array)
);