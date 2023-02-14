// Задача:
// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решение не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами
// Примеры: 
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
// [“Russia”, “Denmark”, “Kazan”] → []


string[] arr1 = new string[6] {"1234", "1567", "-2", "Hello", "doc", "cat"};
string[] arr2 = new string[arr1.Length];
void SecondArr(string[] arr1, string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr[count] = arr1[i];
        count++;
        }
    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
SecondArr(arr1, arr2);
PrintArr(arr2);
