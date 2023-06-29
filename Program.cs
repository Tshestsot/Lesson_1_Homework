// // Задание №1
// // Console.Write("Введите первое число число: ");
// // int numberA = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите второе число число: ");
// // int numberB = Convert.ToInt32(Console.ReadLine());
// // {
// //     if (numberA > numberB)
// //     {
// //         Console.WriteLine($"{numberA} больше {numberB}");
// //     }
// //     else
// //     {
// //         Console.WriteLine($"{numberA} меньше {numberB}");
// //     }

// // }
// // Задание №2
// Console.Write("Введите первое число число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число число: ");
// int numberC = Convert.ToInt32(Console.ReadLine());
// int max = numberA;
// {
//     if (numberB > max)
//     {
//         max = numberB;
//     }
//     if (numberC > max)
//     {
//         max = numberC;
//     }

//     Console.WriteLine($"{max}");
// }
// Задание №3
// Console.Write("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// int result = numberA % 2;
// {
// if (result == 0)
// {
// Console.WriteLine($"Число {numberA} является чётным");
// }
// else
// Console.WriteLine($"Число {numberA} НЕ является чётным");
// }
// Задание №4
Console.Write("Введите длину: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);