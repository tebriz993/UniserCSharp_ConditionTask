
//LOOPS

#region Task 1
//long multiple = 1;
//int number = 1;
//while (number < 50)
//{
//    multiple *= number;
//    number += 3;
//}
//console.writeline(multiple);
#endregion

#region Task 2
//int SumOfDividedThreeAndSix = 0;
//int MultipleOfDividedFiveAndTwo = 1;
//int CountOfOddNumbers = 0;

//for (int i = 1; i < 20; i++)
//{
//	if (i%3==0 && i%6==0)
//	{
//        SumOfDividedThreeAndSix += i;
//    }
//	if (i%2==0 && i%5==0)
//	{
//        MultipleOfDividedFiveAndTwo *= i;

//    }
//    if (i % 2 != 0)
//    {
//        CountOfOddNumbers += i;
//    }
//}
//Console.WriteLine($"Sum of divided by three and six is {SumOfDividedThreeAndSix}");
//Console.WriteLine($"Multiple of divided by five and two is {MultipleOfDividedFiveAndTwo}");
//Console.WriteLine($"Count of odd numbers is {CountOfOddNumbers}");
#endregion

#region Task 3
//int number = Convert.ToInt32(Console.ReadLine());
//int SumOfPositives = 0;
//int CountOfZeros = 0;

//if (number < 0)
//{
//    Console.WriteLine("Verilmis eded sifirdan kicikdir...");
//}

//else
//{

//    while (number > 0)
//    {
//        int numbersInsideOfnumber = number % 10;
//        if (numbersInsideOfnumber > 0)
//        {
//            SumOfPositives += numbersInsideOfnumber;
//        }
//        else if (numbersInsideOfnumber == 0)
//        {
//            CountOfZeros++;
//        }
//        number /= 10;
//    }
//    Console.WriteLine($"Verilmis ededin musbet reqemlerin cemi {SumOfPositives}-dir");
//    Console.WriteLine($"Verilmis ededdeki sifirlarin sayi {CountOfZeros}-dir");

//}
#endregion

#region Task 4

//int number=Convert.ToInt32(Console.ReadLine());
//int numbersOfnumber = 0;

//while (number > 0)
//{
//    numbersOfnumber = number % 10;
//    Console.Write(numbersOfnumber);

//    number /= 10;
//}
#endregion

#region Task 5
//Console.WriteLine("Sehifeye daxil olmaq ucun login ve paswordu duzgun qeyd etmelisiniz, eger cehdiniz 3-den cox olarsa sehifeye daxil ola  bilmeyeceksiniz");

//string userLogin = "booleanteach";
//string userPassword = "booleanms13";

//for (int i = 1; i <= 3; i++)
//{
//    Console.Write("Login daxil edin: ");
//    string enteredLogin = Console.ReadLine();

//    Console.Write("Password daxil edin: ");
//    string enteredPassword = Console.ReadLine();

//    if (userLogin != enteredLogin && userPassword != enteredPassword)
//    {
//        Console.WriteLine("Login ve password yanlisdir...");
//    }
//    else if (userLogin != enteredLogin)
//    {
//        Console.WriteLine("Login yanlisdir...");
//    }
//    else if (userPassword != enteredPassword)
//    {
//        Console.WriteLine("Password yalnisdir...");
//    }
//    else
//    {
//        Console.WriteLine("Sehifeye daxil oldunuz...");
//        break;
//    }


//    if (i != 3)
//    {
//        Console.WriteLine("Yeniden cehd edin...");

//    }
//    else
//    {
//        Console.WriteLine("Teessuf ki sehifeye daxil ola bilmediniz...");
//    }
//}
#endregion

//ARRAYS
#region Task 1
//Console.Write("Arraydaki element sayini daxil edin: ");
//int studentCount=Convert.ToInt32(Console.ReadLine());
//string[] student = new string[studentCount];

//for (int i = 0; i<studentCount;i++)
//{
//    student[i]=Console.ReadLine();
//}

//Console.WriteLine("Arraydaki elementler: ");
//foreach (var item in student)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Task 2
//int[] numbers = new int[5];
//int SumOfEven = 0, MultipleOfOdd = 1;

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = Convert.ToInt32(Console.ReadLine());

//   if (numbers[i] % 2 == 0)
//   {
//        SumOfEven += numbers[i];
//   }

//   else if (numbers[i]%2!=0)
//        {
//        MultipleOfOdd *= numbers[i];
//        }

//}
//Console.WriteLine($"Cut ededlerin cemi: {SumOfEven}");
//Console.WriteLine($"Tek ededlerin hasili: {MultipleOfOdd}");
#endregion

#region Task 3
//int[] numbersA = { 4, 6, -3, 44, -5 };
//int[] numbersB = { 9, 6, 100, 11, -20 };

//int numbersA_Max = 0;
//int IndexOfMaxA = 0;

//int numbersB_Min = 101;
//int IndexOfMinB = 0;

//for (int i = 0; i < numbersA.Length; i++)
//{
//	if (numbersA[i] > numbersA_Max)
//	{
//		numbersA_Max = numbersA[i];
//		IndexOfMaxA = i;
//	}
//}

//for (int j = 0; j < numbersB.Length; j++)
//{
//	if (numbersB[j] < numbersB_Min)
//	{
//		numbersB_Min = numbersB[j];
//		IndexOfMinB = j;
//	}
//}

//int temp = numbersA[IndexOfMaxA];
//numbersA[IndexOfMaxA] = numbersB[IndexOfMinB];
//numbersB[IndexOfMinB] = temp;

//foreach (var itemsA in numbersA)
//{
//	Console.Write($"{itemsA} ");
//}

//Console.WriteLine("\n");

//foreach (var itemsB in numbersB)
//{
//	Console.Write($"{itemsB} ");
//}
#endregion

#region Task 4
int[,] matrixA =
{
    {1, 2, 3},
    {4, 5, 6}
};

int[,] matrixB =
{
    {7, 8},
    {9, 10},
    {11, 12}
};

int rowsA = matrixA.GetLength(0);
int colsA = matrixA.GetLength(1);
int rowsB = matrixB.GetLength(0);
int colsB = matrixB.GetLength(1);

if (colsA != rowsB)
{
    Console.WriteLine("Matrix multiplication is not possible with the given matrices...");
}
else
{
    int[,] productMatrix = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }

            productMatrix[i, j] = sum;
            Console.WriteLine($"productMatrix[{i},{j}]: {productMatrix[i, j]}");
        }
    }
}
#endregion






