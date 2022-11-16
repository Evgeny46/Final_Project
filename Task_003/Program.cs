/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

 Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int m = int.Parse(Console.ReadLine()); 
System.Console.WriteLine("Введите второе число: ");
int n = int.Parse(Console.ReadLine()); 
int FunctionAkkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    else if(m > 0 && n > 0) return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    return FunctionAkkerman(m, n);
}
System.Console.WriteLine($"Результат вычисления функции Аккермана: {FunctionAkkerman(m,n)}");