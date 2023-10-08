// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.



// System.Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number <= 999 && number >= 100)
// {
//   int result =  (number % 100 / 10);
//   System.Console.WriteLine("Вторая цифра числа: " + result);
// }
// else 
// {
//     System.Console.WriteLine("Введено не трехзначное число");
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.



// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number <= 999 && number >= 100)
// {
//     int result = (number % 10);
//     System.Console.WriteLine("Третья цифра числа: " + result);
// }
// else if (number < 100)
// {
//     System.Console.WriteLine("Третьей цифры в данном числе нет");
// }
// else
// {
//     int numberOK = number;
//     while (numberOK > 1000)
//     {
//         numberOK = (numberOK / 10);
//     }
//     numberOK = numberOK % 10;
//     System.Console.WriteLine("Третья цифра числа: " + numberOK);
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



System.Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 1){
    System.Console.WriteLine("Нет, это рабочий день");
}
else if(day == 2){
    System.Console.WriteLine("Нет, это рабочий день");
}
else if(day == 3){
    System.Console.WriteLine("Нет, это рабочий день");
}
else if(day == 4){
    System.Console.WriteLine("Нет, это рабочий день");
}
else if(day == 5){
    System.Console.WriteLine("Нет, это рабочий день");
}
else if(day == 6){
    System.Console.WriteLine("Да, это выходной день");
}
else if(day == 7){
    System.Console.WriteLine("Да, это выходной день");
}
else{
    System.Console.WriteLine("Такого дня недели не существует");
}