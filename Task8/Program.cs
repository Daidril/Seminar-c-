//Вывести числа от -N до N
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int minusNumber = -number;
while(minusNumber <= number)
{
    Console.WriteLine(minusNumber);
    minusNumber++;
}