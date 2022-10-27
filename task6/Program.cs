// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98
Console.Clear ();
int num = new Random(). Next (100, 1000);
int a1 = num/100;
int a2 = num%10;
int count1 = a1*10;
int count = count1+a2;
Console.WriteLine($"Число a1={a1}, число a2={a2}");
Console.WriteLine($"Число {num} сократилось до {count}");
