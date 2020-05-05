using System;
using Controllers;
using Models;

namespace View 
{
	public class ClienteView 
    {
        public void addCliente(int idCliente, string nome, string dataNasc, string cpf, int diaDev) 
            {
                ClienteController.addCliente(idCliente, nome, dataNasc, cpf, diaDev);
            }

        public void getCliente(ClienteModels cliente)
            {
                Console.Write(cliente);
            }

        public static void GetClientes()
            {
                ClienteController.GetClientes().ForEach(cliente => Console.WriteLine(cliente));
            }
    }

}