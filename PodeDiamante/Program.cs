namespace DiamanteDeXis
{
    internal class Program
    {   //Padrões da parte superior do diamante:
        //- A quantidade de espaços na primeira linha é o (número -1) /2
        //- A quantidade de espaços em branco é reduzido em 1 a cada linha.
        //- A quantidade inicial de x será sempre 1. 
        //- A quantidade de X é adicionado em 2 a cada linha. 

        //Parte 2 - Desenhar a linha do meio. 

        static void Main(string[] args)
        {
            int tamanhoDiamante; //valor imputado pelo usuário
            Console.WriteLine("Shine Bright Like a Diamond");
            tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            
            while(tamanhoDiamante %2 == 0) // repetição para ver se o número é par ou ímpar. 
            {
                Console.WriteLine("O número é par! Informe um número ímpar.");
                tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            }

            int quantidadeDeXis = 1; //Quantidade Inicial de x.
            int quantidadeBranco = (tamanhoDiamante - 1) / 2; // primeiro padrão. 
            int quantidadeDeLinhas = (tamanhoDiamante - 1) / 2;

            #region Parte superior do diamante
            for (int i = 0; i < quantidadeDeLinhas; i++)
            {
                for(int j = 0; j < quantidadeBranco; j++)
                
                    Console.Write(" ");
                
                quantidadeBranco--; //quantidade de espaços em branco é reduzida em 1 a cada linha;
                for (int k = 0; k < quantidadeDeXis; k++)
                
                    Console.Write("x");
                
                quantidadeDeXis += 2;//quantidade de x +2 a cada linha (até a metade).
                Console.WriteLine();
            }
            #endregion
            #region Linha central
            for (int t = 0; t < tamanhoDiamante; t++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
            #endregion
            #region Linha inferior do diamante
            quantidadeBranco = 1;
            quantidadeDeXis -= 2;
            
            for(int g = 0; g < quantidadeDeLinhas; g++) // parte de baixo do diamante
            {
                for(int h = 0; h < quantidadeBranco; h++)
                {
                    Console.Write(" ");
                }
                for(int r = 0; r <quantidadeDeXis; r++)
                {
                    Console.Write("x");
                }
                quantidadeBranco++;
                quantidadeDeXis -= 2;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
        #endregion
    }
}