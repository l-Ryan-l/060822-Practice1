//Switch Case по сути условие которое проверятся последовательно и в случае выполнения не идет дальше.

string name = "Валера";

switch (name)
{
    case "Валера":
        Console.WriteLine("Первое приветствие...");
        break;
    case "Петя":
        Console.WriteLine("Второе приветствие...");
        break;
    default:
        Console.WriteLine("Обычное приветствие...");
        break;
}

