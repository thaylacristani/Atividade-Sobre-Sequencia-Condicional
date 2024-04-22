namespace restaurante;

class tabelaPrecos
{
    static void Main(string[] args)
    {
        //peça ao usuário um codigo e uma quantidade
        Console.WriteLine("Informe o código e a quantidade de produtos: ");
        string[] entrada = Console.ReadLine().Split(' ');

        //após separar os valores da entrada e array, destine os valores a posicoes e nomeie como variavel
        int codigoProduto = int.Parse(entrada[0]);
        int quantidadeProduto = int.Parse(entrada[1]);

        //crie uma tabela de preços que guarda um código e um valor para esse código
        Dictionary<int, double> tabelaPrecos = new Dictionary<int, double>
        {
            { 1, 4.00 }, 
            { 2, 4.50 },
            { 3, 5.00 },
            { 4, 2.00 },
            { 5, 1.50 },
        };

        //busque o valor do produto na tabela
        double precoProduto = tabelaPrecos[codigoProduto];

        //faça o calculo do valor total usando o cod produto para consultar o valor na tabela e qnt informada
        double valorTotal = precoProduto * quantidadeProduto;

        Console.WriteLine("\nTotal: R$" + valorTotal);
    }
}
