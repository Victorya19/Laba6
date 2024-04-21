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
        Console.WriteLine("5 - Квадратный корень");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
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

        double result = 0;

        switch (choice)
        {
            case 1:
                Console.WriteLine("Введите второе число:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Неверный формат числа.");
                    return;
                }
                result = num1 + num2;
                break;
            case 2:
                Console.WriteLine("Введите второе число:");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Неверный формат числа.");
                    return;
                }
                result = num1 - num2;
                break;
            case 3:
                Console.WriteLine("Введите второе число:");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Неверный формат числа.");
                    return;
                }
                result = num1 * num2;
                break;
            case 4:
                Console.WriteLine("Введите второе число:");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Неверный формат числа.");
                    return;
                }
                if (num2 == 0)
                {
                    Console.WriteLine("Деление на ноль невозможно. Попробуйте еще раз.");
                    return;
                }
                result = num1 / num2;
                break;
            case 5:
                if (num1 < 0)
                {
                    Console.WriteLine("Извлечение квадратного корня из отрицательного числа невозможно.");
                    return;
                }
                result = Math.Sqrt(num1);
                break;
            default:
                Console.WriteLine("Неверный выбор операции.");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}
