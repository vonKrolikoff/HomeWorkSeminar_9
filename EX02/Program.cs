// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = Input("Введите M: ");
int n = Input("Введите N: ");
int x = m;

if (m > n) 
{
  m = n; n = x;
}
PrintSumm(m, n, x=0);

int Input(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {summ}");
    return;
  }
  PrintSumm(m, n - 1, summ);
}