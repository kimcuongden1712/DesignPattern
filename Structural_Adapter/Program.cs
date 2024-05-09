int[] numbers = { 5, 3, 9, 2, 8, 1, 4, 7, 8 };
bool swapped;
do
{
    swapped = false;
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        while (numbers[i] > numbers[i + 1])
        {
            int temp = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = temp;
            swapped = true;
        }
    }
} while (swapped);

foreach (var number in numbers)
{
    Console.Write(number + " ");
}