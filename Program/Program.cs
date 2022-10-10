// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 
// 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

Console.Clear();
Console.Write("Введите заданные данные через запятую: ");
string[] a = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine(a);
string[] b = new string[a.Length];
int index = 0;


for (int i = 0; i < a.Length; i++)
    {
        
        if(a[i].Length<= 3)
        {
            b[index] = a[i];
            index++;
        }
    }
    void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
PrintArray(b);

