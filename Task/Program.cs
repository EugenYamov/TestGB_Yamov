//Программа, которая формирует массив строк, длина элементов которого равна или меньше 3 символов

//Алгоритм заполнения пользовательского массива
string[] userArray = new string[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Введите {i+1} из 6 элементов массива");
    userArray[i] = Console.ReadLine();
}

//Алгоритм подсчитывающий размер результирующего массива
int size = 0;
for (int i = 0; i < 6; i++)
{
    if (userArray[i].Length <= 3)
    {
        size++;
    }
}

//Объявляем пустой массив, в который будет записываться результат
string[] resultArray = new string[size];

//Алгоритм записывающий результирующие элементы из пользовательского массива
int j = 0;
for (int i = 0; i < 6; i++)
{
    if (userArray[i].Length <= 3)
    {
        resultArray[j] = userArray[i];
        j++;
    }
}

Console.WriteLine($"\nВаш массив: {String.Join(", ", userArray)}\n");
Console.WriteLine($"Результат: {String.Join(", ", resultArray)}\n");