Console.WriteLine("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
numberA = Math.Abs(numberA);
int numberB = -numberA;
while(numberB <= numberA)
{
 Console.Write(numberB + " ");
 numberB++;    
}
