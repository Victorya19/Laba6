using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");
        Console.WriteLine("4 - Деление");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Неверный выбор операции.");
            return;
        }

        Console.WriteLine("Введите первое число:");
        double num1;
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Неверный формат числа.");
            return;
        }

        Console.WriteLine("Введите второе число:");
        double num2;
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Неверный формат числа.");
            return;
        }

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
                if (num2 == 0)
                {
                    Console.WriteLine("Деление на ноль невозможно. Попробуйте еще раз.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Неверный выбор операции.");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}
