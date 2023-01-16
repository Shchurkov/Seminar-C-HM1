// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите значение A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B ");
int B = Convert.ToInt32(Console.ReadLine());

if ( A > B )
{
Console.WriteLine ("A больше B");
}

else if ( B > A )
{
 Console.WriteLine ("B больше A");   
}
else
{
    Console.Write("Значения равны");
}