﻿
// Имеется одномерный массив ARRAY из N элементов, требуется найти элемент массива, равный FIND

int [] array = {1,12,31,4,18,15,16,17,18};

int n=array.Length;
int find=4;

int index=0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}



