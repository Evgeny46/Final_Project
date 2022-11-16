/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */


Console.Clear();

System.Console.WriteLine("Введите минимальное значение промежутка: ");
int M = int.Parse(Console.ReadLine()); 
System.Console.WriteLine("Введите максимальное значение промежутка: ");
int N = int.Parse(Console.ReadLine()); 
int PrintEvenNumber(int M, int N)
{
    if(M >= N) return M;
    else return M + PrintEvenNumber(M + 1, N);
}

System.Console.WriteLine(PrintEvenNumber(M, N));  
