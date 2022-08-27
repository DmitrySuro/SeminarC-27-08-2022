/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и
 замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 ==0)
            {
                array[i,j] *=  array[i,j];
            }

        }
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
ChangeArray(array);
PrintArray(array);