void InputArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write("Введите значение элемента массива: ");
    array[i] = Console.ReadLine();
  }
}

Console.Clear();

Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n];
string[] array2 = new string[n];
int j = 0;

InputArray(array1);

for (int i = 0; i < array1.Length; i++)
{
    var l = array1[i].Length;
    if (l <= 3)
    {
        array2[j] = array1[i];
        j++;
    }
}

Array.Resize(ref array2, j);

Console.WriteLine($"Начальный массив: [{string.Join("; ", array1)}]");
Console.WriteLine($"Конечный массив: [{string.Join("; ", array2)}]");