using System;

string[] array1 = {"Putin", "Petrozavodsk", "T34", "VVP", "Kreml", "YRA", "!!!"};
string[] array2 = new string [array1.Length];

void FinalArray (string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
            {
                array2[j] = array1[i];                
                j++;
            }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();

    
FinalArray (array1, array2);
PrintArray (array2);