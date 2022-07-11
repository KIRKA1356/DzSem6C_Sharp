/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

/*
Console.WriteLine("Укажите количество цифр которое вы хотите ввести");
int x = Convert.ToInt32(Console.ReadLine());                                      //Задача 41
    
int kolvoelementov(int x)
{
   int[] array = new int[x];
   int sum = 0;
   Console.WriteLine("Введите числа, после каждого введенного числа нажимайте Enter");   
   for (int i = 0; i < array.Length; i++)
     {
        array[i]=Convert.ToInt32(Console.ReadLine());
        if (array[i]>0) sum = sum + 1;
     }
     return sum;
}

Console.WriteLine("Кол-во значений больше нуля в вашем ряду: " + kolvoelementov(x));
*/

/*
Console.WriteLine("Укажите b1");
int b1 = Convert.ToInt32(Console.ReadLine());               //Задача 43
Console.WriteLine("Укажите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите k2");
int k2 = Convert.ToInt32(Console.ReadLine());

int[] tochka(int b1, int k1, int b2, int k2)
{
   int[] peresech = new int[2];
   int x;
   int y;
   x=b2-b1/k1-k2;
   y=k1*x+b2;
   peresech[0] = x;
   peresech[1] = y;
   return peresech;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i==0) Console.Write("(" + array[i] + ";");
        if (i==1) Console.Write(" " + array[i] + ")");
    }
    Console.WriteLine();
}

int[] MyArray = tochka( b1, k1, b2, k2);
Console.WriteLine("Точка пересечения имеет координаты:");
ShowArray(MyArray);
*/