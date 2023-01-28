int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//       index  0   1   2   3   4   5   6   7   8
int[] array = { 15, 88, 39, 11, 23, 35, 16, 23, 323 };
array[0] = 97;  // Изменение значения элемента массива по индексу
// Вывод значения элемента массива с индексом 0
Console.WriteLine("Первый этемент массива = " + array[0]); 

int max = Max(
            Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8])
            );

Console.WriteLine("Максимальное число = " + max);
