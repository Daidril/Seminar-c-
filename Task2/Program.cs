Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnumber = Convert.ToInt32(Console.ReadLine());
//Proverka na yslovie
if (firstnumber * firstnumber == secondnumber)
{
    Console.WriteLine("Является квадратом первого числа");
}
else
{
    Console.WriteLine("Неявляется квадратом первого числа");
}
