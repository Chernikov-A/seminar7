/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
/*
int row = Convert.ToInt32(Console.ReadLine());
int colomns = Convert.ToInt32(Console.ReadLine());

double[,] size = new double[row, colomns];

void Array(){
    for (int i = 0; i < size.GetLength(0); i++)
    {
        for (int j = 0; j < size.GetLength(1); j++)
        {
            size[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray(){
    for (int i = 0; i < size.GetLength(0); i++)
    {
       for (int j = 0; j < size.GetLength(1); j++)
       {
        Console.Write($"{size[i,j]:F1}"+" ");
       } 
       Console.WriteLine();
    }
    Console.WriteLine();
}

Array();
PrintArray();



/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

/*
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во стобцов: ");
int colomns = Convert.ToInt32(Console.ReadLine());

double[,] size = new double[row,colomns]; 

void Array(){
    for (int i = 0; i < size.GetLength(0); i++)
    {
        for (int j = 0; j < size.GetLength(1); j++)
        {
            size[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray(){
    for (int i = 0; i < size.GetLength(0); i++)
    {
       for (int j = 0; j < size.GetLength(1); j++)
       {
        Console.Write($"{size[i,j]:F1}"+" ");
       } 
       Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите интекс строки нужного элемента: ");
int RowIndex = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс стобца нужного элемента: ");
int ColomnsIndex = Convert.ToInt32(Console.ReadLine());

void ElemtnsSearch(){
    for (int i = 0; i < size.GetLength(0); i++)
    {
        if (RowIndex == i+1)
    {
            for (int j = 0; j < size.GetLength(1); j++)
        {
            if (ColomnsIndex == j+1)
            {
                Console.WriteLine($"{RowIndex},{ColomnsIndex} нужный элемент: {size[i,j]}");
            }
        }
    }
        
    }
    if(RowIndex>size.GetLength(0) || ColomnsIndex > size.GetLength(1)){
        Console.WriteLine("Такого элемента нет");
    }
}
Array();
ElemtnsSearch();
PrintArray(); */

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int strok = ReadInt("Введите количество строк: ");
int stolb = ReadInt("Введите количество столбцов: ");
int[,] size = new int[strok, stolb];



void FillArrayD(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(1, 10);
        }
    }
}
double[] avgNumbers = new double[size.GetLength(1)];

for (int i = 0; i < size.GetLength(1); i++)
{
 double result = 0;
 for (int j = 0; j < size.GetLength(0); j++)
    {
        result += size[j, i];
    }
        avgNumbers[i] = result / size.GetLength(0);
}
PrintArray(avgNumbers);

void PrintArrayD(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 for (int j = 0; j < array.GetLength(1); j++)
        {
 Console.Write(array[i, j] + " ");
        }
 Console.WriteLine();
    }
 Console.WriteLine();
}
void PrintArray(double[] array)
{
 for (int i = 0; i < array.Length; i++)
    {
 Console.Write(array[i] + " ");
    }
 Console.WriteLine();
}

int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
FillArrayD(size);
PrintArrayD(size);