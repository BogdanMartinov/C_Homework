// Задача1. Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа
// в промежутке от M до N.

// void FromToMandN (int m, int n)
// {
//     if (m>n)
//     {
//         FromToMandN(m-1,n);
//         System.Console.Write(m + " ");
//     }
//     else if (n>m)
//     {
//         FromToMandN(n-1,m);
//         System.Console.Write(n + " ");
//     }
//     else System.Console.Write(m + " ");
// }

// FromToMandN(6,2);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if(m == 0)
//     {
//         return n + 1;
//     }
//     else if(n == 0)
//     {
//         return Akkerman(m-1, 1);
//     }
//     else
//     {
//         return Akkerman(m-1, Akkerman(m, n-1));
//     }
// }

// System.Console.WriteLine("Введите первое неотрицательное число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе неотрицательное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = Akkerman(m,n);
// System.Console.WriteLine($"Результат функции Аккермана: {result}");