﻿string[] InputArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input the element of the massive: ");
        array[i] = Console.ReadLine();
       
    }
     return array;
}

 void PrintArray (string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");  
    Console.WriteLine("\b\b ]");
}


Console.Write("Input the size of the massive: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] newArray = InputArray(size);
PrintArray(newArray);
