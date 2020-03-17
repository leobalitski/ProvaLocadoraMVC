using System.Collections.Generic;
using Models;

namespace Repositories 
{
    public static class LocacaoRepositories 
    {
        private static readonly List<Models.LocacaoModels> locacoes = new List<Models.LocacaoModels>();

        public static List<LocacaoModels> Locacoes()
            {
                return locacoes;
            }

        public static void AdicionarLocacao(LocacaoModels locacao)
            {
                locacoes.Add(locacao);
            }
    }
}