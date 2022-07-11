/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// int[] ThreeDigitArray (int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     array[i] = new Random().Next(100, 1000);

//     return array;
// }

// int EvenNumbersArray (int[] array)
// {
//     int n = 0;
//     for(int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0) n++;
//         Console.Write(n);
    
//     return n;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] myArray = ThreeDigitArray(5);
// ShowArray(myArray);
// EvenNumbersArray(myArray);

/*
Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// int[] ThreeDigitArray2 (int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     array[i] = new Random().Next(1, 100);

//     return array;
// }

// int EvenNumbersArray2 (int[] array)
// {
//     int n = 0;
//     for(int i = 0; i < array.Length; i++)
//         if (array[i] % 2 != 0) n += array[i];
//         Console.Write(n);
    
//     return n;
// }

// void ShowArray2(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] myArray2 = ThreeDigitArray2(5);
// ShowArray2(myArray2);
// EvenNumbersArray2(myArray2);

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// double[] ThreeDigitArray3 (double size, double min, double max)
// {
//     Random rnd = new Random();
//     double[] array = new double[5];
//     for(int i = 0; i < size; i++)
//     array[i] = rnd.Next(0, 100);
    
//     return array;
// }

// double[] DifferenceElementsArray (double[] array)
// {
//     double max = 0, min = 100, result = 0;        
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];
//         result = max - min;    
//     }
//     Console.Write("Разницу между min и max: " + result);    
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(" "+ array[i]);
//     Console.WriteLine();
                    
// }

// double[] myArray = ThreeDigitArray3(5, 100, 0);
// ShowArray(myArray);
// DifferenceElementsArray(myArray);