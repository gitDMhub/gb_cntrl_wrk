// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] matrix = new string [1];
Console.Clear();
Console.Write("Введите любые слова через пробел: ");
matrix = Console.ReadLine().Split(' '); // ввод слов в одну строку
Console.WriteLine("Исходный массив слов: ");
for (int i = 0; i < matrix.Length; i++)
    {
    if (matrix[i].Length == 0)
        Console.WriteLine("empty");
    else
        Console.WriteLine(matrix[i]);
    }
string [] matrixNew = new string [matrix.Length];
int j = 0;
Console.WriteLine("Массив слов короче 4х букв: ");
for (int i = 0; i < matrix.Length; i++)
    if (matrix[i].Length < 4)
        {
        matrixNew[j] = matrix[i];
        if (matrixNew[j].Length == 0)
            Console.WriteLine("тут пусто");
        else
            Console.WriteLine(matrixNew[j]);
        j++;
        }