// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// // Console.WriteLine("Какое колличество чисел Вы хотите ввести?");
// // int quantityNumber = int.Parse(Console.ReadLine());
// // int [] array = new int [quantityNumber];
// // int calculateNumbers = 0;
// // int FillArrayUserNumbers (int number)
// // {
// //     for (int i = 0; i < number; i++)
// //     {
// //         Console.WriteLine($"Введите {i + 1} число:");
// //         array[i] = int.Parse(Console.ReadLine());
// //     }
// //     return number;
// // }
// // int CalculateArrayNumbers (int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if (array[i] > 0)
// //             calculateNumbers += 1;
// //     }
// //     return calculateNumbers;
// // }
// // void PrintArray (int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write($"| {array[i]} ");
// //     }
// //     Console.WriteLine("|");       
// // }
// // FillArrayUserNumbers(quantityNumber);
// // CalculateArrayNumbers(array);
// // PrintArray(array);
// // Console.WriteLine($"Во введённом массиве чисел больше 0 = {calculateNumbers}");


// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double [] array = new double[4];
// double x = 0;
// double y = 0;
// void AssignmentValue(double [] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//             Console.Write($"Введите значение: ");
//             array[i] = Convert.ToDouble(Console.ReadLine());
//     }
// }
// void SearchCollision(double [] array)
// {
//     x = (array[2] - array[0]) / (array[1] - array[3]);
//     y = array[1] * x + array[0];
// }
// Console.WriteLine("Введите значения x1, y1, x2, y2:");
// AssignmentValue(array);
// SearchCollision(array);
// Console.WriteLine($"Две прямые пересекаются в точке: ({x}; {y})");