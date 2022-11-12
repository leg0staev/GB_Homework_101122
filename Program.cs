Console.WriteLine("========= Задача 64 ==============");

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("введите значение N, и я выведу все все натуральные числа в промежутке от N до 1");
int n1 = InputNumbers("введите N = ");
Console.WriteLine(GetNaturalNumberz(n1));


string GetNaturalNumberz(int n)
{
    if (n == 1) return "1";
    return (n + ", " + GetNaturalNumberz(n - 1));
}


Console.WriteLine("========= Задача 66 ==============");
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте значения M и N, и я выведу сумму натуральных элементов в интревале значений между M и N");
int n2 = InputNumbers("введите N = ");
int m = InputNumbers("введите M = ");
Console.WriteLine($"сумму натуральных элементов в интревале значений M и N = {SumNaturalElements(n2, m)}");

int SumNaturalElements(int n, int m)
{
    if (n > m)
    {
        if (n == m) return m;
        return n + SumNaturalElements(n-1, m);
    }
    if (n == m) return n;
    return m + SumNaturalElements(m-1, n);
}



Console.WriteLine("========= Задача 68 ==============");
//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Задайте значения M и N, и я выведу значение функции Аккермана");

int m3 = InputNumbers("введите M = ");
int n3 = InputNumbers("введите N = ");

Console.WriteLine($"При М={m3} и N={n3} функция Аккермана = {Akkerman(m3, n3)}");


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


//общий метод ввода
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}