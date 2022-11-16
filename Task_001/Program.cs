/* 
 Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

Console.Clear();

System.Console.WriteLine("Введите минимальное значение промежутка: ");
int M = int.Parse(Console.ReadLine()); 
System.Console.WriteLine("Введите максимальное значение промежутка: ");
int N = int.Parse(Console.ReadLine()); 
void PrintEvenNumber(int M, int N)
{
    if(M > N) return;
    else if(M % 2 == 0) System.Console.Write(M + " ");
    M++;
    PrintEvenNumber(M, N);
}
System.Console.WriteLine("Четные натуральные числа из заданного промежутка: ");
PrintEvenNumber(M, N);  