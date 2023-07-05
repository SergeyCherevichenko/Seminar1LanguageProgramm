string [] week = new string [7] {"Monday", "Thuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine("Введите номер дня недели: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1)
{
    Console.Write("Это " );
    Console.Write(week[0]);
}
if (numberA == 2)
{
Console.WriteLine("Это ");
Console.Write(week[1]);
}
if (numberA == 3)
{
    Console.Write("Это ");
    Console.Write(week[2]);
}
if(numberA == 4)
{
    Console.Write("Это ");
    Console.Write(week[3]);
}
if(numberA == 5)
{
    Console.Write("Это ");
    Console.Write(week[4]);
}
if(numberA == 6)
{
    Console.Write("Это ");
    Console.Write(week[5]);
}
if(numberA == 7)
{
    Console.Write("Это ");
    Console.Write(week[6]);
}
if(numberA < 1|| numberA > 7)
{
    Console.Write("Такого дня недели не существует!!!");
}
