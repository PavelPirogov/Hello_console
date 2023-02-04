//====== Функции (методы) 4 вида

//==== Вид 1 (Ничего не принимает, ничего не возвращает) void метод
// void Method1()
// {
//     Console.WriteLine("Автор ..."); // Нужен например для авторства  
// }
// Method1();


//==== Вид 2 (Что-то принимает, ничего не возвращает)
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;    // увеличение счётчика на единицу называют - инкиментом
//     }           // уменьшение счётчика на единицу называют - декриментом
// }
// // Method21("Текст сообщения", 4);
// Method21(count: 4, msg: "Текст сообщения"); // Именованные аргументы необязательно писать по порядку

//==== Вид 3 (Ничего не принимает, что-то возвращает)
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//==== Вид 4 (Что-то принимает, что-то возвращает)
// string Method4(int count, string c)
// {
// // int i=0;
// string result = String.Empty;  // Пустая строка
// // while(i<count)
// // {
// //     result = result + c + " ";
// //     i++;
// // }
// string result = String.Empty;
// for (int i = 0; i < count; i++)
// {
//     result = result + c + " ";
// }
// return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

//====== Цикл For
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012345 
// s[3]  //  r
// string Replase(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// Console.WriteLine();
// string newText = Replase(text, ' ', '-');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();

//====== Упорядочить массив
int[] array = { 5, 9, 6, 3, 8, 7, 5, 1, 2, 36, 4, 8, 6, 7, 4, 56 };
void printArray(int[] array)
{
    int count = array.Length;
    for (int i= 0; i<count;i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
printArray(array);
void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}
SelectionSort(array);
printArray(array);