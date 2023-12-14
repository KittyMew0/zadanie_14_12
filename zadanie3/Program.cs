/* Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива. */

var random = new Random();
Console.WriteLine("enter a length of array");
int len = Convert.ToInt32(Console.ReadLine());
double[] darray = new double[len];

for (int i = 0; i < len; i++) {
    darray[i] = random.NextDouble() * 10;
    Console.WriteLine("Element {0}: {1}", i, darray[i]);
}

double min = darray[0], max = darray[0], diff = 0;
for (int i = 0; i < len; i++) {
    if (min > darray[i]) {
        min = darray[i];
    }
    if (max < darray[i]) {
        max = darray[i];
    }
}

Console.WriteLine($"diff = {max} - {min} = " + (max - min));