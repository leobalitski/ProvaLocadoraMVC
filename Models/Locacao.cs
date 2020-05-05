using System;
using System.Collections.Generic;
using Controllers;
using Repositories;

namespace Models 
{
	public class LocacaoModels 
	{
		// Atributos
		public int IdLocacao { get; set; }
		public ClienteModels Cliente { get; set; }
		public DateTime DataLocacao { get; set; }

		public List<FilmeModels> filmes = new List<FilmeModels>();

		// Construtor
		public LocacaoModels (int idLocacao, ClienteModels cliente) 
			{
				IdLocacao = idLocacao;
				Cliente = cliente;
				DataLocacao = DateTime.Today;

				Repositories.LocacaoRepositories.AdicionarLocacao(this);
			}

			// Adição de Filmes
		public void AdicionarFilme(FilmeModels filme) 
			{
				filmes.Add(filme);
			}

		public override string ToString() 
		{
			return  $"-> PREÇO TOTAL DAS LOCAÇÕES: R$ {LocacaoController.PrecoTotalLocaçoes(filmes)}\n" +
					$"-> DATA DE DEVOLUÇÃO: {LocacaoController.calculoDataDevolucao(DataLocacao)}\n" +
					$"-> QTDE TOTAL DE FILMES LOCADOS: {LocacaoController.TotalFilmes(filmes)}\n";
					
		}

		public static List<LocacaoModels> GetLocacaoModels() {
			return LocacaoRepositories.Locacoes();
		}

			
	}
}