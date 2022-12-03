string[] initArray = {"Russia", "Denmark", "Kazan"};
string[] resultArray = new string[initArray.Length];
int j = 0;
for (int i = 0; i < initArray.Length; i++)
{
    if (initArray[i].Length <= 3)
    {
        resultArray[j] = initArray[i];
        j++;
    }
}
for (int i = 0; i < j; i++) Console.Write($"{resultArray[i]}, ");
if (j == 0) Console.WriteLine("В массиве нет строк длиной 3 символа и менее.");