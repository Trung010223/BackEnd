Console.OutputEncoding = System.Text.Encoding.UTF8;

void xapXep(int[] myArray)
{
    int n = myArray.Length;
    int temp;
    for (int j = 0; j < n - 1; j++)
    {
        for (int i = 0; i < n - 1 - j; i++)
        {
            if (myArray[i] > myArray[i + 1])
            {
                temp = myArray[i + 1];
                myArray[i + 1] = myArray[i];
                myArray[i] = temp;
            }
        }
    }
}

int[] numbers = { 5, 1, 8, 3, 9, 7, 6 };
xapXep(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(" " + numbers[i]);
}