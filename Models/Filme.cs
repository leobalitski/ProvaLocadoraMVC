using System;
using Repositories;
using System.Collections.Generic;

namespace Models
{
    public class FilmeModels
    {
    // Atributos
    public int IdFilme { get; set; }
    public String Titulo { get; set; }
    public string DataLancamento { get; set; }
    public string Sinopse { get; set; }
    public double ValorLocacaoFilme { get; set; }
    public int EstoqueFilme { get; set; }
    public int FilmeLocado { get; set; }

    public List<LocacaoModels> locacaos = new List<LocacaoModels>();

    // Construtor
    public FilmeModels (int idFilme, string titulo, string dataLancamento, string sinopse, double valorLocacaoFilme, int estoqueFilme) 
        {
            IdFilme = idFilme;
            Titulo = titulo;
            DataLancamento = dataLancamento;
            Sinopse = sinopse;
            ValorLocacaoFilme = valorLocacaoFilme;
            EstoqueFilme = estoqueFilme;
            FilmeLocado = 0;

            FilmeRepositories.filmes.Add(this);
        }

    // Método com a Quantidade de locações Realizadas
    public void filmefilmeLocado() 
        {
            EstoqueFilme -= 1;
            FilmeLocado += 1;
        }

    // Impressão Dados do Filme
    public override string ToString() 
        {
            return  $"----------------------------FILME----------------------------------------------------------------------------------------------------------\n\n" +
                    $"--> Nº ID DO FILME: {IdFilme}\n" + 
                    $"-> TÍTULO: {Titulo}\n" + 
                    $"-> DATA DE LANÇAMENTO: {DataLancamento}\n" + 
                    $"-> SINOPSE: {Sinopse}\n" + 
                    $"-> VALOR DA LOCAÇÃO: R$ {ValorLocacaoFilme}\n" + 
                    $"-> QTDE EM ESTOQUEFilme: {EstoqueFilme}\n" + 
                    $"-> QTDE DE LOCAÇÕES REALIZADAS: {FilmeLocado}\n" + 
                    $"-------------------------------------------------------------------------------------------------------------------------------------------";
        }
        public static List<FilmeModels> GetFilmes()
			{
				return Repositories.FilmeRepositories.filmes;
			}
    }
}