//task 1
//float[] points = [];


//if (points.Length == 0)
//{
//    Console.WriteLine("Points is empty");
//    return;
//}

//float sum = 0;

//foreach (var point in points)
//    sum += point;

//float averagePoint = sum / points.Length;

//Console.WriteLine("Average point:" + averagePoint);

//if (averagePoint > 50)
//    Array.Sort(points);
//else
//    Array.Reverse(points);


//foreach (var point in points)
//    Console.WriteLine(point);


//task 2

//float[] tempratures = [12, 12, 34, 12, 41, 31, 12];

//if (tempratures[0] > tempratures[^1])
//{
//    Array.Reverse(tempratures);
//}
//else
//{
//    Array.Sort(tempratures);
//}


//task 3

decimal[] prices = [123, 321, 321, 34, 412, 41, 432, 431, 41, 41, 41];

//Array.Sort(prices);
//decimal min = prices[0];
//decimal max = prices[^1];

//decimal min = prices[0];
//decimal max = prices[0];
//decimal sum = 0;

//foreach (var price in prices)
//{
//    if (price > max)
//        max = price;

//    if (price < min)
//        min = price;

//    sum += price;
//}

//if(min<20)
//    Console.WriteLine("20 manatdan ucuz mehsul var");

//if(max>100)
//    Console.WriteLine("Bahali mehsul var");

//decimal averagePrice = sum / prices.Length;




//task 4
//int[] numbers = [213, 312, 321, 321, 31, 2, 321, 321, 321, 321];

//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}

//task 5

//int[] numbers1 = [21, 213, 321, 1, 34, 124, 431];
//int[] numbers2 = [21, 1, 31];

//if (numbers1.Length != numbers2.Length)
//{
//    Console.WriteLine("Saylar eyni deyil");
//    return;
//}

//for (int i = 0; i < numbers1.Length; i++)
//{
//    Console.WriteLine(numbers1[i] + numbers2[i]);
//}



//task 9

//int[] numbers = [1, 4, 1, 2, 2, 3, 3];

//for (int i = 0; i < numbers.Length; i++)
//{
//    bool isRepated = false;
//    for (int j = 0; j < numbers.Length; j++) //i=1   j=0
//    {
//        if (i != j && numbers[i] == numbers[j])
//        {
//            isRepated = true;
//        }

//    }

//    if (isRepated == false)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}


//task 10
int[] numbers = [21, 321, 1, 56, 43, 421, 31]; //21,321 , 56,43,421,31,0

int deletedNumber = 43;
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

        numbers[^1] = 0;
    }
}

if (isExist == false)
{
    Console.WriteLine("Item is not found");
}

foreach (var number in numbers)
{
    Console.WriteLine(number);
}