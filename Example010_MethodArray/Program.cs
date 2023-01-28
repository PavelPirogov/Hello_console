int[] array = { 20, 93, 74, 5, 26, 347, 8, 5, 10, 181, 12, 133, 114, 15 };

int n = array.Length; // Количестро элементов в массиве
int find = 5;
Console.WriteLine("Искомое число " + find);

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Индекс искомого числа " + index);
        break;
    }
    index++;
}
//Console.WriteLine("Искомое число в массиве не найдено");