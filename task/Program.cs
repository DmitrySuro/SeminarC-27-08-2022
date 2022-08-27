/*Дана последовательность из N целых чисел и число K. 
Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
если K – положительное и влево, если отрицательное.*/

System.Console.Clear();

int[] NewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2,100);
    }
    return array;
}

int[] ShiftArray(int[] array,int shiftK)
{
 
    for (int i = 0; i < array.Length/ 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }

   for (int i = 0; i < (array.Length - shiftK) / 2; i++)
    {
        int temp = array[i];
        array[i] = array[(array.Length -shiftK) - i - 1];
        array[(array.Length - shiftK) - i - 1] = temp;
    }
  
    

return array;
}

System.Console.WriteLine("Введите насколько мы сдвигаем массив");
int shiftK = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Ввелите размер массива");
int size = int.Parse(Console.ReadLine()!);

int[] array = new int[size];
array = NewArray(array);

System.Console.WriteLine("Первоначальный массив");
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine("Сдвинутый массив");
System.Console.WriteLine("[" + string.Join(", ", ShiftArray(array, shiftK)) + "]");
