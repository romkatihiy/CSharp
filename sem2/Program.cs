// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int randomNumber = new Random().Next(10, 100); // [10, 100)
// System.Console.WriteLine(randomNumber);

// int leftDigit = randomNumber / 10;
// int rightDigit = randomNumber % 10;

// if (leftDigit > rightDigit)
// {
//     System.Console.WriteLine(leftDigit);
// }
// else
// {
//     System.Console.WriteLine(rightDigit);
// }






// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98





// Random rand = new Random();
// int randomNumber = rand.Next(100, 1000);
// System.Console.WriteLine(randomNumber);
// int leftDigit = randomNumber / 100;
// int rightDigit = randomNumber % 10;
// int result = leftDigit * 10 + rightDigit;
// System.Console.WriteLine(result);



// System.Console.WriteLine(randomNumber + " -> " + result + " text " + 12 + " text2 ");
// System.Console.WriteLine($"{randomNumber} -> {result} text {12} text2");


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно




// System.Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 == 0)
// {
//     System.Console.WriteLine("Первое число является кратным второму");
// }
// else
// {
//     System.Console.WriteLine("Числа не являются кратными, остаток равен " + (number1 % number2));
// }



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
// System.Console.WriteLine("Yes");
// }
// else
// {
//     System.Console.WriteLine("No");
// }






// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет



System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2 || number2 == number1 * number1)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}