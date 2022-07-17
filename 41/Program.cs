/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите количество вводимых чисел и сами числа ");
int n = Convert.ToInt32(Console.ReadLine());
int numPosinives = 0;

for( int i = 0; i < n; i++) {
    int digit = Convert.ToInt32(Console.ReadLine());
    if (digit > 0) {
        numPosinives++;
    }
}
Console.WriteLine("чисел больше 0: "+ numPosinives);