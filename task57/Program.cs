/*
Задача 57: Составить частотный словарь 
элементов двумерного массива. 
Частотный словарь содержит информацию о том,
сколько раз встречается элемент входных данных.
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

void FindElementsInArray(int[,] array)
{
    
    int count = 0;
    int j = 0;
    while (j < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int temp = array[i,j];
            if (temp == array[i,j])
            {
            count ++;
            }

        }
        j++;
    }
    System.Console.Write(count);
}

int[,] array = GetArray(4,4,4,4);

FindElementsInArray(array);


/*int[,] CalcCountOfElements(int[,] array)
{
    int[,] unicValue = new int[2, array.GetLength(0) * array.GetLength(1)];
    int indexLast = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            bool isFinded = false;
            for (int k = 0; k < unicValue.GetLength(1); k++)
            {
                if (array[i, j] == unicValue[0, k])
                {
                    unicValue[1, k]++;
                    isFinded = true;
                    break;
                }
            }
            if (!isFinded)
            {
                unicValue[0, indexLast] = array[i, j];
                unicValue[1, indexLast]++;
                indexLast++;
            }
        }
    }
    return unicValue;
}
*/
/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
->
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза
*/

int[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    int[,] array = new int[rows, columns];
    var ran = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = ran.Next(minRandomValue, maxRandomValue + 1);
        }
    }
    return array;
}

int[,] CalcCountOfElements(int[,] array)
{
    int[,] unicValue = new int[2, array.GetLength(0) * array.GetLength(1)];
    int indexLast = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            bool isFinded = false;
            for (int k = 0; k < unicValue.GetLength(1); k++)
            {
                if (array[i, j] == unicValue[0, k])
                {
                    unicValue[1, k]++;
                    isFinded = true;
                    break;
                }
            }
            if (!isFinded)
            {
                unicValue[0, indexLast] = array[i, j];
                unicValue[1, indexLast]++;
                indexLast++;
            }
        }
    }
    return unicValue;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = 4;
int columns = 4;
int minValue = 1;
int maxValue = 5;
int[,] array = GetArray(rows, columns, minValue, maxValue);
Console.Write($"Исходный массив [{rows}*{columns}], ");
Console.WriteLine($"в диапазоне {minValue} до {maxValue}:");
ShowArray(array);

int[,] UnicValue = CalcCountOfElements(array);

Console.WriteLine($"Таблица уникальности");
ShowArray(UnicValue);