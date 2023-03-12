#pragma warning disable

int TaskIndex = 0;

Console.Write("Пожалуйста, введите номер задачи: ");
int.TryParse(Console.ReadLine(), out TaskIndex);

switch (TaskIndex)
{
    case 1:
    int TrinityNumber = new Random().Next(100, 1000);
    int MiddleNumber = (TrinityNumber % 100) / 10;
    Console.WriteLine($"В числе: {TrinityNumber} вторая цифра {MiddleNumber}");
    break;

    case 2:
    int Number = new Random().Next(0, 100000000);
    int Lenght;
    int result = 0;
    int i = Number;
    Lenght = Number.ToString().Length;
    if (Lenght < 3)
    {
        Console.WriteLine("Третьей цифры нет");
        break;
    }
    else
    {
        while (i > 0)
        {
            result = result*10 + i%10;
            i /= 10;
        }
        
        Lenght = result.ToString().Length;
        
        if (Lenght == 3)
        {
            result = (result % 100) / 10;
        }
        else
        {
            result = (result % 1000) / 100;
        }
        Console.WriteLine($"В числе {Number} третья цифра {result}!");
    }
    break;

    case 3:
    int WeekNumber = new Random().Next(1,8);
    if (WeekNumber == 6 || WeekNumber == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    break;

    default:
    Console.WriteLine("Выбран неверный номер задачи!");
    break;
}
    