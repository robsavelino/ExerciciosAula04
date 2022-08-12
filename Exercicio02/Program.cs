using Exercicio02;

int length = GetInput.GetLength();

int[] arrayInput = new int[length];
int[] arrayAux = new int[length];
int[] arrayRank = new int[length];
Dictionary<int, int> numberRank = new Dictionary<int, int>();


GetInput.GetArray(arrayInput, length);

for (int i = 0; i < length; i++)
{
    arrayAux[i] = arrayInput[i];
}

Array.Sort(arrayAux);

GetInput.GetRank(arrayAux, arrayInput, numberRank, arrayRank, length);

Print.PrintArray(arrayInput);
Print.PrintArray(arrayRank);

