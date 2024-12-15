using System;
using System.Threading.Channels;

namespace Assignment4
{
    internal class Program
    {
        #region Funcation
        //Q1
        //static void ModifyByValue(int number)
        //{
        //    number = 115; // This change is local to this method
        //}

        //static void ModifyByReference(ref int number)
        //{
        //    number = 115; // This change affects the original variable
        //}

        //Q2
        //static void ModifyArrayByValue(int[] array)
        //{
            
        //    array[0] = 99;

            
        //    array = new int[] { 7, 8, 9 };
        //}

        //static void ModifyArrayByReference(ref int[] array)
        //{
        //    array[0] = 42;

        //    array = new int[] { 10, 11, 12 };
        //}
        //Q3

        //static  (int, int) Calculate(int a, int b, int c, int d)
        //{
        //    int sum = a + b + c + d;
        //    int diff = (a + b) - (c + d);
        //    return (sum, diff);
        //}
        //Q4
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}

        //Q5
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;

        //    // Find the largest number to check (manual sqrt)
        //    int limit = 1;
        //    while (limit * limit <= number)
        //    {
        //        limit++;
        //    }
        //    limit--; // Correct the overshoot

        //    for (int i = 2; i <= limit; i++)
        //    {
        //        if (number % i == 0) return false;
        //    }

        //    return true;
        //}
        //Q6

        //static void MinMaxArray(int[] array, out int min, out int max)
        //{
        //    // Initialize min and max with the first element of the array
        //    min = array[0];
        //    max = array[0];

        //    // Iterate through the array to find min and max
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //        }
        //        if (array[i] > max)
        //        {
        //            max = array[i];
        //        }
        //    }
        //}

        //Q7
        //static int Factorial(int number)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Quetion01

            #endregion
            #region Quetion02
            //
            //Console.WriteLine("Enter the time of the Employee");
            //int time =Convert.ToInt32(Console.ReadLine());
            //if (time>=2 && time<=3)
            //    Console.WriteLine("highly efficient");
            //else if(time<=4) 
            //    Console.WriteLine("increase their speed");
            //else if (time<=5)
            //    Console.WriteLine("they are provided with training to enhance their speed");
            //else
            //    Console.WriteLine("required to leave the company");

            #endregion
            #region Quetion03
            //
            //Console.WriteLine(" Identity Matrix");
            //Console.Write("Enter size n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(i == j ? "1 " : "0 ");
            //    Console.WriteLine();
            //}
            #endregion
            #region Quetion20
            //
            //Console.WriteLine("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Enter The Element Num:{i+1}");
            //}

            //int sum = 0;
            //foreach (int num in array)
            //{
            //    sum += num;
            //}

            //Console.WriteLine($"The sum of all elements in the array is: {sum}");
            #endregion
            #region Quetion21
            //Console.WriteLine("Enter the size of the arrays: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array1 = new int[n];
            //int[] array2 = new int[n];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < n; i++)
            //{

            //    array1[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Enter The Element num:{i + 1}");


            //}

            //Console.WriteLine("Enter the elements of the second array:");
            //for (int i = 0; i < n; i++)
            //{

            //    array2[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Enter The Element num:{i + 1}");

            //}

            //int[] mergedArray = array1.Concat(array2).ToArray();

            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion
            #region Quetion22
            //Console.WriteLine("Enter the size of the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter the element num:{i + 1}");
            //    array[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //Dictionary<int, int> frequency = new Dictionary<int, int>();
            //foreach (int num in array)
            //{
            //    if (frequency.ContainsKey(num))
            //        frequency[num]++;
            //    else
            //        frequency[num] = 1;
            //}

            //Console.WriteLine("Frequency of each element:");
            //foreach (var pair in frequency)
            //{
            //    Console.WriteLine($"Element {pair.Key} appears {pair.Value} time(s).");
            //}
            #endregion
            #region Quetion23
            //Console.WriteLine("Enter the size of the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter the elements of num:{i+1}");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int max = array[0];
            //int min = array[0];

            //foreach (int num in array)
            //{
            //    if (num > max) max = num;
            //    if (num < min) min = num;
            //}

            //Console.WriteLine($"Maximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");
            #endregion
            #region Quetion24
            //Console.WriteLine("Enter the size of the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter the element num:{i+1}");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Array.Sort(array);
            //int secondLargest = array[n - 2];

            //Console.WriteLine($"The second largest element is: {secondLargest}");
            #endregion
            #region Quetion28
            //Console.WriteLine("Enter the size of the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter the element of the array Num:{i + 1}");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Array in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Funcation
            #region Quetion01
            //Changes to a value parameter are not visible to the caller(also called "pass by value").
            //Changes to a reference parameter are visible to the caller("pass by reference").
            //int valuePassedByValue = 185;
            //int valuePassedByRef = 185;

            //Console.WriteLine("Before method call:");
            //Console.WriteLine($"Value Passed By Value: {valuePassedByValue}");
            //Console.WriteLine($"Value Passed By Reference: {valuePassedByRef}");

            //// Passing by value
            //ModifyByValue(valuePassedByValue);

            //// Passing by reference
            //ModifyByReference(ref valuePassedByRef);

            //Console.WriteLine("\nAfter method call:");
            //Console.WriteLine($"Value Passed By Value: {valuePassedByValue}");
            //Console.WriteLine($"Value Passed By Reference: {valuePassedByRef}");

            #endregion
            #region Quetion02
            //int[] arrayByValue = { 1, 2, 3 };
            //int[] arrayByReference = { 4, 5, 6 };

            //Console.WriteLine("Before method call:");
            //Console.WriteLine($"Array By Value: {string.Join(", ", arrayByValue)}");
            //Console.WriteLine($"Array By Reference: {string.Join(", ", arrayByReference)}");

            //// Passing reference type by value
            //ModifyArrayByValue(arrayByValue);

            //// Passing reference type by reference
            //ModifyArrayByReference(ref arrayByReference);

            //Console.WriteLine("\nAfter method call:");
            //Console.WriteLine($"Array By Value: {string.Join(", ", arrayByValue)}");
            //Console.WriteLine($"Array By Reference: {string.Join(", ", arrayByReference)}");
            #endregion
            #region Quetion03
            //Console.WriteLine("Enter four numbers:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int num4 = Convert.ToInt32(Console.ReadLine());

            //(int sum, int diff) = Calculate(num1, num2, num3, num4);

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {diff}");
            #endregion
            #region Quetion04
            //
            //Console.WriteLine("Enter a number:");
            //int num = int.Parse(Console.ReadLine());

            //int sum = SumOfDigits(num);

            //Console.WriteLine($"The sum of the digits of the number {num} is: {sum}");
            #endregion
            #region Quetion05
            //Console.WriteLine("Enter a number:");
            //int num = int.Parse(Console.ReadLine());

            //bool isPrime = IsPrime(num);
            //Console.WriteLine(isPrime ? $"{num} is a prime number." : $"{num} is not a prime number.");
            #endregion
            #region Quetion06
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter the elements of the array num:{i+2}");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //MinMaxArray(array, out int min, out int max);

            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");

            #endregion
            #region Quetion07
            //Console.WriteLine("Enter a number:");
            //int num = int.Parse(Console.ReadLine());

            //int factorial = Factorial(num);
            //Console.WriteLine($"Factorial of {num} is: {factorial}");
            #endregion
            #endregion
        }
    }
}
