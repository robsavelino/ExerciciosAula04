using Exercicio03;

int linha = 0;
int coluna = 0;

linha = GetInput.GetLinhas();
coluna = GetInput.GetColunas();

int[,] matriz = new int [linha, coluna];

GetInput.GetMatriz(matriz, linha, coluna);
Print.PrintMatriz(matriz, linha, coluna);
