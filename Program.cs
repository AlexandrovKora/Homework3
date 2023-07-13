/*
Задача 19 Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.
*/
/*
bool CheckPal(int num)
{
    int decthous=num/10000;
    int thous = (num/1000)-decthous*10;
    int units = num%10;
    int dec = ((num%100)-units)/10;
    if (decthous==units && thous==dec) return true;
    else return false;
}
Console.Write("Input 5-ranked number: ");
string number = Console.ReadLine();
int numberresult = Convert.ToInt32(number);
Console.WriteLine(CheckPal(numberresult));
*/
/*Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
*/
/*
double Diagonal(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x2 - x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return result;
}
Console.Write("Input X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Z1: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Diagonal(X1, Y1, Z1, X2, Y2, Z2));
*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

void Cube(int num)
{
    int count=1;
    while (count<=num)
    {
    Console.WriteLine($"{count} - {count*count*count}");
    count++;
    }
}
Console.Write("Input you number: ");
int pow3=Convert.ToInt32(Console.ReadLine());
Cube(pow3);
