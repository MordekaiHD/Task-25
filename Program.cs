// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void ShowNumber(int x, int y, double pow_xy)
{
    pow_xy = Math.Pow(x, y);
    Console.Write(pow_xy);
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int x = GetInput("Введите число А: ");
int y = GetInput("Введите число B: ");
double pow_xy = 0;
ShowNumber(x, y, pow_xy);