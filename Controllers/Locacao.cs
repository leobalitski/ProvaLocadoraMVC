using System;
using System.Collections.Generic;
using Models;

namespace Controllers 
{
    public class LocacaoController
    {
        public static LocacaoModels addLocacao(int idLocacao, ClienteModels cliente)
            {
                return new LocacaoModels(idLocacao, cliente);
            }

		// Método com o Valor Total das Locações (Preço)
		public static double PrecoTotalLocaçoes(List<FilmeModels> filmes) 
			{
                double ValorTotal = 0;

				foreach (FilmeModels filme in filmes) 
					{
						ValorTotal += filme.ValorLocacaoFilme;
					}

                return ValorTotal;
			}

		// Calculo Data de Devolução
		public static string calculoDataDevolucao(DateTime Data) 
		{
			//Data.AddDays(ClienteModels.Dias);
			return Data.ToString().Substring(0,10);
		}

        public static double TotalFilmes(List<FilmeModels> filmes) 
			{
                return filmes.Count;
			}

        public static List<LocacaoModels> GetLocacaoModels(){
            return LocacaoModels.GetLocacaoModels();
        }

		
    }      
}