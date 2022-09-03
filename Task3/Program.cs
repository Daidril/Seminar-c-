Console.WriteLine("Введите номер дня, от 1 до 7: ");
int firstday = Convert.ToInt32(Console.ReadLine());

//Выводим день недели 
switch(firstday)
{
    case  1:
    Console.WriteLine("Понедельник");
    break;

    case  2:
    Console.WriteLine("Вторник");
    break;

    case  3:
    Console.WriteLine("Среда");
    break;

    case  4:
    Console.WriteLine("Четверг");
    break;

    case  5:
    Console.WriteLine("Пятница");
    break;

    case  6:
    Console.WriteLine("Суббота");
    break;

    case  7:
    Console.WriteLine("Воскресение");
    break;

    default:
    Console.WriteLine("Число не входит в диапозон");
    break;
}