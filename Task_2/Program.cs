// Программа которая на принимает на вход число и выдает сумму цифр в числе 

Console.WriteLine("Введите число" );
int Namber = Convert.ToInt32(Console.ReadLine());

int Summa (int N)
{
    int res = 0; 
    for (int i = 0; N > 0; i++)
    {
        int s = N % 10;
        res = res + s;
        N = N / 10;
    }
    return res;
}
    
Console.WriteLine(Summa(Namber));