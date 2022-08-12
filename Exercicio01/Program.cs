using Exercicio01;

int[] arrayNumbers = new int[10];
int[] arrayOdd = new int[10];
int[] arrayEven = new int[10];
int countOdd = 0;
int countEven = 0;

GetInput.GetArray(arrayNumbers, 10);
Array.Sort(arrayNumbers);

(countEven, countOdd) = GetInput.GetArrayOddEven(arrayNumbers, 10, arrayOdd, arrayEven, countOdd, countEven);
Console.Clear();

Console.WriteLine("Array completo");
Print.PrintArray(arrayNumbers, 10);

Console.WriteLine("Array de numeros pares");
Print.PrintArray(arrayEven, countEven);

Console.WriteLine("Array de numeros impares");
Print.PrintArray(arrayOdd, countOdd);

Console.ReadKey();