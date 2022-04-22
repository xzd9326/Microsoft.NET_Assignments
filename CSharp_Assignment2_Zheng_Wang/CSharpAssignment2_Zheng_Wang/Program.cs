int[] array = new int[10] {1, 3, 5, 7, 9, 2, 4, 6, 8, 10};
int[] copiedArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    copiedArray[i] = array[i];
}
Console.WriteLine("Original Array: " + String.Join(",", array));
Console.WriteLine("Copied Array: " + String.Join(",", array));

