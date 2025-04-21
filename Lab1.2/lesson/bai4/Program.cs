Console.OutputEncoding = System.Text.Encoding.UTF8;

int FindSecondLargest(int[] myArray)
{
    int largest = int.MinValue;
    int secondlargest = int.MinValue;

    foreach (int number in myArray)
    {
        if (number > largest)
        {
            secondlargest = largest;
            largest = number;
        }
        else if (number > secondlargest && number < largest) {
            secondlargest = number;
        }
    }
    return secondlargest;
}

int[] numbers = { 5, 1, 8, 3, 9, 7, 6 };
int secondLargest = FindSecondLargest(numbers);

Console.WriteLine("Số lớn thứ hai trong mảng là: " + secondLargest);