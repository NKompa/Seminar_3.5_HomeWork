// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

int [] array = new int [5];
int Max = 0;
int Min = 100;
int Diff = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    if(array[i]>Max)
    {
        Max = array[i];
    }
    else if(array[i]<Min)
    {
        Min = array[i];
    }
}
Diff = Max - Min;
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(Diff);