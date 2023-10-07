//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница
// System.Console.WriteLine("Введите номер дня");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day == 1){
//     System.Console.WriteLine("Понедельник");
// }
// else if(day == 2){
//     System.Console.WriteLine("Вторник");
// }
// else if(day == 3){
//     System.Console.WriteLine("Среда");
// }
// else if(day == 4){
//     System.Console.WriteLine("Четверг");
// }
// else if(day == 5){
//     System.Console.WriteLine("Пятница");
// }
// else if(day == 6){
//     System.Console.WriteLine("Суббота");
// }
// else if(day == 7){
//     System.Console.WriteLine("Воскресенье");
// }
// else{
//     System.Console.WriteLine("Такого дня недели не существует");
// }





// Console.Write("Программа выводит день недели введённого числа.\n\rВведите число:");
// int daynum = Convert.ToInt32(Console.ReadLine());
// string iday = "";

// switch(daynum){
//     case 1:
//         iday = "Понедельник";
//         break;
//     case 2:
//         iday = "Вторник";
//         break;
//     case 3:
//         iday = "Понедельник";
//         break;
//     case 4:
//         iday = "Вторник";
//         break;
//     case 5:
//         iday = "Понедельник";
//         break;
//     case 6:
//         iday = "Вторник";
//         break;
//     case 7:
//         iday = "Понедельник";
//         break;
//     default:
//         iday = "Введённое число не имеет совпадения с днём недели!";
//         break;

// }

// Console.WriteLine($"День недели: {iday}");








// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"



// System.Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int index = -N;
// while(index <= N)
// {
// System.Console.Write(index +" ");
// index++;
// }




// Console.WriteLine("Введите число");
// int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// int index = -N;

// while (index <= N)
// {
//     Console.Write(index + " ");
//     index++;
// }




// Console.WriteLine("Введите число");
// int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// for(int i = -N; i <= N; i++)
// {
//     System.Console.Write(i + " ");
// }






// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8




// System.Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number > 99 && number < 1000)
// {
//     System.Console.WriteLine(number%10);
// }
// else
// {
//     System.Console.WriteLine("Введено не трехзначное число");
// }





System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100 || number > 999)
{
    System.Console.WriteLine("Введено не трехзначное число");
    return;
}

    System.Console.WriteLine(number % 10);
