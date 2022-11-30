Console.Write("Введите количестов чисел, которые будет введены с клавиатуры:\t");
int elemetCount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elemetCount];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i} :\t ");
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] myArray)
{
    Console.Write("Вывод массива: ");

    for (int i = 0; i < myArray.Length; i++)
        Console.WriteLine($"\n{myArray[i]}");

}
int GetPositiveElem(int[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
        if (myArray[i] > 0) count += 1;
    return count;
}
PrintArray(myArray);
int PositiveElem = GetPositiveElem(myArray);
Console.WriteLine($"Положительных чисел в массиве = {PositiveElem}");


















