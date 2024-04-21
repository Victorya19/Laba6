using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Выберите операцию:" );
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");
        Console.WriteLine("4 - Деление");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Неверный выбор операции.");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}
