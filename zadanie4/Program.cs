/* Задача 4: Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий 
из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, 
младший – на последнем. Размер массива должен быть равен количеству цифр. */

Console.WriteLine("enter a number ");
int num = Convert.ToInt32(Console.ReadLine());

int num2 = num;
int count = 0;

while (num > 0) {
    num = num / 10;
    count++;
}

int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--) {
    array[i] = num2 % 10;
    num2 = num2 / 10;
}

for (int i = 0; i < array.Length; i++) {
    Console.Write(array[i] + " ");
}