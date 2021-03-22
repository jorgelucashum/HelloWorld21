using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld21
{
    class Program
    {
        // Matriz: É o nome dado à arranjos (arrays) bidimensionais (linhas e colunas)
        // Array é uma estrutura de dados: 
        // - Homogênea  (dado do mesmo tipo)
        // - Ordenada (elementos acessados por meio de posições)
        // - Alocada de uma vez só, em um bloco contíguo de memória
        // Vantagens: acesso imediato aos elementos pela sua posição.
        // Desvantagens: Tamanho fixo e Dificuldade para se realizar inserções e deleções.
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3]; // '[,]' indica que é uma matriz. Sendo '[2, 3]' linhas e colunas respectivamente ('2' linhas e '3' colunas).

            Console.WriteLine(mat.Length); // '.Length' retorna o tamanho total, nesse caso da matriz.

            Console.WriteLine(mat.Rank); // '.Rank' retorna a primeira dimensão da matriz, nesse caso a quantidade de linhas.

            Console.WriteLine(mat.GetLength(0)); // '.GetLength' retorna o tamanho da dimensão do número no parâmetro, nesse caso o '0' está na primeira dimensão (linhas).
            Console.WriteLine(mat.GetLength(1)); // '1' está na segunda dimensão (colunas)


            Console.ReadLine();
        }
    }
}
