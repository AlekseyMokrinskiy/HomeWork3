
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
void Palidrom(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = (num / 1000) % 10;
    int thirdGigit = (num / 100) % 10;
    int fourthDigit = (num / 10) % 10;
    int fifthDigit = num % 10;

    if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.WriteLine($"{num} -> Yes");
    else Console.WriteLine($"{num} -> No");
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Palidrom(number);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double katet1 = x2 - x1;
    double katet2 = y2 - y1;
    double katet3 = z2 - z1;
    return Math.Sqrt(katet1 * katet1 + katet2 * katet2 + katet3 * katet3);
}

Console.WriteLine("Введите точку 1 ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку 2 ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($" расстояние между точками {dist} ");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void Cube(int num)
{
    int ind = 1;
    while (ind <= num)
    {
        if (ind == num) Console.Write($"{ind * ind * ind} ");
        else Console.Write($"{ind * ind * ind}, "); 
        ind++;
    }
    
}
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Cube(n);
*/