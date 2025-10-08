#region task1
//restart:

//string text = Console.ReadLine();

//foreach (var item in text)
//{
//    if (char.IsDigit(item) == false)
//    {
//        Console.WriteLine("Duzgun deyer daxil edin");
//        goto restart;
//    }
//}

//int number = int.Parse(text);

//Console.WriteLine(number);
#endregion


#region Task2

//int number;
//restart:
//bool isParsed = int.TryParse(Console.ReadLine(), out number);

//if (isParsed == false || number < 0)
//{
//    Console.WriteLine("Duzgun deyer daxil edin");
//    goto restart;
//}

////24213 2
//int max = number % 10;

//number /= 10;

//while (number > 0)
//{
//    int step = number % 10;
//    number /= 10;

//    if (step > max)
//        max = step;
//}

//Console.WriteLine(max);
#endregion 
//1,2,4,5,5=>1,2,4,5
int[] numbers = [1, 2, 3, 4, 5];
int deletedNumber = 1;
bool isExist = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (deletedNumber == numbers[i])
    {
        isExist = true;
        for (int j = i; j < numbers.Length - 1; j++)
        {
            numbers[j] = numbers[j + 1];
        }
        Array.Resize(ref numbers, numbers.Length - 1);
        break;
    }
}


if (isExist == false)
    Console.WriteLine("Element is not found");
else
{
    foreach (var item in numbers)
    {
        Console.WriteLine(item);
    }
}