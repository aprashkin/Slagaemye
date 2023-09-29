using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое положительное число: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Все возможные слагаемые числа {number}:");

        FindCombinations(number, "");
    }

    static void FindCombinations(int target, string currentCombination)
    {
        // цикл для перебора всех возможных слагаемых от 1 до таргет
        if (target == 0)
        {
            
            Console.WriteLine(currentCombination.TrimEnd('+'));
            return;
        }
        // удаляется последний символ и выводится в виде суммы как комбинация
        for (int i = 1; i <= target; i++)
        {
            FindCombinations(target - i, currentCombination + i + "+");
        }
    }
}
// а вообще я битмейкер