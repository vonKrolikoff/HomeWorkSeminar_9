// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = Input("Введите M: ");
int n = Input("Введите N: ");
int funct = FunctAk(m, n);

Console.Write("Функция Аккермана = " + funct);

int Input(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int FunctAk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctAk(m - 1, 1);
  else return FunctAk(m - 1, FunctAk(m, n - 1));
}