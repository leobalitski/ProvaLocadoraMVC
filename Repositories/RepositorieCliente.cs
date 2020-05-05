using Models;
using System.Collections.Generic;

namespace Repositories
{
    public class ClienteRepositories
    {
		public static List<ClienteModels> clientes = new List<ClienteModels>();

		public static void ImportarCliente()
		{
			// Lista com 5 ClienteModelss
			ClienteModels cliente1 = new ClienteModels(1,
			"Adriano Medeiros Sá", "21/01/1978", "123.123.123-12", 3);
			//clientes.Add(cliente1);

			ClienteModels cliente2 = new ClienteModels(2,
			"João  ", "13/08/1945", "456.456.456-45", 2);
			//clientes.Add(cliente2);

			ClienteModels cliente3 = new ClienteModels(3,
			"Fátima ", "02/12/2001", "789.789.789-78", 3);
			//clientes.Add(cliente3);

			ClienteModels cliente4 = new ClienteModels(4,
			"  Soares", "11/12/1989", "098.098.098-09", 2);
			//clientes.Add(cliente4);
			
			ClienteModels cliente5 = new ClienteModels(5,
			" Schmmitt", "15/07/2023", "753.753.753-75", 3);
			//clientes.Add(cliente5);
		}             
    }
}