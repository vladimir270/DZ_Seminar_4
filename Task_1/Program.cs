// Программа в котором цикл принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень

Console.WriteLine("Введите число 1" );
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2" );
int B = Convert.ToInt32(Console.ReadLine());


int Nature (int A, int B)
{
    int resuilt = A;
    for(int i = 1; i < B; i++)
    {
        resuilt = resuilt * A;
    }
   return resuilt;

}

Console.WriteLine(Nature(A,B));