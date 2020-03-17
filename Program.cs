using System;
using View;
using Repositories;

/**
 *  @author Kadu Floresta
 * 
 * 
*/

namespace ViewLocadora
{
	public class Principal 
	{
		public static void Main(String[] args) 
		{	
		ClienteRepositories.ImportarCliente();
		FilmeRepositories.ImportarFilme();

		Console.WriteLine("LOCADORA DE FILMES MVC");

		// IdCliente / Menu
		int menu = 0;
		do 
		{ 
            Console.WriteLine("\n___________________________________");			  
              Console.WriteLine("|____________MENU_________________|");
			  Console.WriteLine("|*********************************|"); 
              Console.WriteLine("| 1 > Inserir Locação             |");
              Console.WriteLine("| 2 > Listar Clientes             |");
			  Console.WriteLine("| 3 > Listar Filmes               |");
			  Console.WriteLine("| 4 > Listar Locações             |");
              Console.WriteLine("|_________________________________|");
			  Console.WriteLine("|*********************************|\n");

			//Entrada Menu
			Console.WriteLine("\nDigite a Opção: ");
            String Digito = Console.ReadLine();
			menu = Convert.ToInt32(Digito);

			switch (menu)
			{
				case 1: // locacao
					LocacaoView.AdicionarLocacao();
					break;
				case 2: // clientes
					ClienteView.GetClientes();
					break;
				case 3: // filmes
					FilmeView.GetFilmes();
					break;
				case 4: // locação
					LocacaoView.ImprimirLocacao();
					break;

			}
		} while (menu <= 4);
			
		}
	}
}