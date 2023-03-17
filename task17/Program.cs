// int[] array = new int[8]; // говорим компилятору сколько нужно выделить памяти  каждый 4 байта, тоесть в сумме 32 байта. 
// // 8 это колличество элементов 0,1,2,3,4,5,6,7
// array[3] = 34;


// int[] array = new int[8];
// array[3] = 34;
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0,2);
//   Console.Write(array[i] + " "); 
// }

// // int[] arr = { 1, 2, 3 } // можно и так, но иногда нужен пустой





// int[] array = new int[8];

// void FillArr(int[] arr)
// {
//   for (int i = 0; i < array.Length; i++)
// {
//   arr[i] = new Random().Next(0,2);
// }
// }

// void PrintArr(int[] arr)
// {
// for (int i = 0; i < array.Length; i++)
// Console.Write(array[i] + " ");
// }

// FillArr(array);
// PrintArr(array);



int[] array = new int[8];
FillArray(array);
PrintArray(array);
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

    {
        Console.Write(array[i] + " ");
    }

}