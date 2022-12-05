// Console.Write ("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine(number*number);

Console.Write ("Введите первое число: ");
int a = int.Parse(Console.ReadLine()); 
Console.Write ("Введите второе число: ");
int b = int.Parse(Console.ReadLine()); 

if (b*b == a){
    Console.WriteLine ("Ответ: Да");
}
else {
    Console.WriteLine ("Ответ: Нет");
}