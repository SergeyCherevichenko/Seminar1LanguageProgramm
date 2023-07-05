Console.WriteLine("Введите первое число: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberY = Convert.ToInt32(Console.ReadLine());
if(numberX * numberX  == numberY )
{ 
Console.Write("Ваше первое число является квадратом второго : ");
Console.Write(numberX);
Console.Write(" * ");
Console.Write(numberX);
Console.Write(" = ");
Console.Write(numberY); 
}
else
{
    Console.Write("Ваше первое число не является квадратом второго: " );
    Console.Write(numberX);
    Console.Write(" * ");
    Console.Write(numberX);
    Console.Write(" не = ");
    Console.Write(numberY);
}