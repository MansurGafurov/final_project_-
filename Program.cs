// Итоговый проект ГАФУРОВ МАНСУР 

string[] array1 = { "sdff", "gdgagG", "RR", "1" };
string[] array2 = new string[2];
int j = 0;

void CheckElements(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}

Console.WriteLine();

void PrintArray(string[] array2)
{
    for (int x = 0; x < array2.Length; x++)
    {
        Console.WriteLine($"элемент {array2[x]}");
    }
}

CheckElements(array1);
PrintArray(array2);
