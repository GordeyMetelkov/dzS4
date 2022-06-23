// Напишите программу, которая задаёт массив 
//из 8 случайных целых чисел и выводит отсортированный по модулю массив.);
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
int [] array = new int[8];
Random rand = new Random();
void select (int[] currentArray)
{
    Console.WriteLine("Набор элементов массива:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(-100, 101);
        Console.Write(currentArray[i]+", ");
    }
    Console.WriteLine();
}
void sort (int[] currentArray)
{
    int k = 0;
    for (int i = 0; i < currentArray.Length-1; i++)
    {
        for (int j = i + 1; j < currentArray.Length; j++ )
        {
            
            if (Math.Abs(currentArray[i])>Math.Abs(currentArray[j]))
            {
                k = currentArray[i];
                currentArray[i] = currentArray[j];
                currentArray[j] = k;
            }
        
        }
    }
}
void print (int[] currentArray)
{
    Console.WriteLine("Набор элементов отсортированного массива");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i]+", ");
    }
}
select (array);
sort (array);
print(array);