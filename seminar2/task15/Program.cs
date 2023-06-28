/*# Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
# Пример:
# - 6 -> да
# - 7 -> да
# - 1 -> нет*/


int Day (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int WeekDay)
{

    if(WeekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateweekDay(int number)
{
    if (number > 0 && number <= 7 )
    {
        return true;
    }
    Console.WriteLine ("Такого дня недели не существует");
    return false;
}
int WeekDay = Day("Введите число дня недели :");
    if (ValidateweekDay(WeekDay))
    {
        if (IsWeekend(WeekDay))
        {
            Console.WriteLine("Выходной");
        }
    else
    {
        Console.WriteLine("Рабочий");
    }
    };