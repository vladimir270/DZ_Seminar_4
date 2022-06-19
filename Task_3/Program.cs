// Программа которая задает массив из 8 элементов и выдает их на экран 

int [] array = new int[8];

void PrintArray(int [] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0, 199);
        Console.Write($"{array[i]} ");
    }
}

PrintArray(array);
