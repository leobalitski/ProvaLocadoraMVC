using System;
using System.Collections.Generic;
using Repositories;

namespace Models 
{
	public class ClienteModels 
	{
		// Atributos
		public int IdCliente { get; set; }
		public String NomeCliente { get; set; }
		public String DataNascimento { get; set; }
		public String CpfCliente { get; set; }
		public int DiasDevolucao { get; set; }

		public List<LocacaoModels> locacoes = new List<LocacaoModels>();

        // Construtor
        public ClienteModels(int idCliente, string nomeCliente, string dataNascimento, string cpfCliente, int diasDevolucao) 
			{
				IdCliente = idCliente;
				NomeCliente = nomeCliente;
				DataNascimento = dataNascimento;
				CpfCliente = cpfCliente;
				DiasDevolucao = diasDevolucao;

				ClienteRepositories.clientes.Add(this);
			}

		// Método com a Quantidade de Filmes locados
		public int QtdeFilmesLocadosCliente() 
			{
				return locacoes.Count;
			}

		// Impressão Dados do CLiente
		public override string ToString() 
			{
				return  $"----------------CLIENTE----------------\n" +
						$"--> Nº ID DO CLIENTE: {IdCliente}\n" +
						$"-> NOMECliente COMPLETO: {NomeCliente}\n" +
						$"-> DATA DE NASCIMENTO: {DataNascimento}\n" +
						$"-> CPFCliente: {CpfCliente}\n" +
						$"-> DIAS P/ DEVOLUÇÃO: {DiasDevolucao}\n";
			}
		// Adição de Locações
		public void AdicionarLocacao(LocacaoModels locacao) 
			{
				locacoes.Add(locacao);
			}

		public static List<ClienteModels> GetClientes()
			{
				return Repositories.ClienteRepositories.clientes;
			}

	}
}