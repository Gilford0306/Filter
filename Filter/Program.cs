//Задание 3
//Напишите метод, фильтрующий массив на основании
//переданных параметров. Метод принимает параметры:
//оригинальный_массив, массив_с_данными_для_фильтрации.
//Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
//Например:
//1 2 6 - 1 88 7 6 — оригинальный массив;
//6 88 7 — массив для фильтрации;
//1 2 - 1 — результат работы метода.


void RemoveAt(ref int[] array, int index)//удаляет элемент массива
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < index; i++)
        newArray[i] = array[i];
    for (int i = index + 1; i < array.Length; i++)
        newArray[i - 1] = array[i];
    array = newArray;
}


int[] filtr(int[] arr, int[] arr2)//находит повторяющийся элемент
{
    for (int j = 0; j < arr2.Length; j++)

    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == arr2[j])
            {
                RemoveAt(ref arr, i);
            }
        }
    }
    return arr;
}

int[] Arr = { 1, 2, 6, -1, 88, 7, 6 };
for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + "\t");
}
Console.WriteLine("\nfilter");
int[] Arr2 = { 6, 88, 7 };
for (int i = 0; i < Arr2.Length; i++)
{
    Console.Write(Arr2[i] + "\t");
}
Console.WriteLine("\nresult"); ;
Arr = filtr(Arr, Arr2);
for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + "\t");
}
