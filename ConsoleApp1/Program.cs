using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое положительное число (или 'exit' для выхода): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Программа завершила выполнение.");
                break;
            }

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Все возможные слагаемые числа {number}:");
                FindCombinations(number, "");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'exit' для выхода.");
            }
        }
    }

    static void FindCombinations(int target, string currentCombination)
    {
        if (target == 0)
        {
            Console.WriteLine(currentCombination.TrimEnd('+'));
            return;
        }

        for (int i = 1; i <= target; i++)
        {
            FindCombinations(target - i, currentCombination + i + "+");
        }
    }
}