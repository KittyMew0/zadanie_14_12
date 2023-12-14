/* Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет 
количество чётных чисел в массиве. */

int[] array = new int[10];
int count = 0;

for (int i = 0; i < 10; i++) {
    array[i] = new Random().Next(0, 101);
    Console.WriteLine(array[i] + " ");
}

for (int i = 0; i < 10; i++) {
    if (array[i] % 2 == 0) {
        count++;
    }
}

Console.WriteLine("количество чётных чисел = " + count);