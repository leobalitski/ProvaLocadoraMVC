using Models;
using System.Collections.Generic;

namespace Controllers
{
    public class FilmeController
    {
        public static void addFilme(int idFilme, string titulo, string dataLanc, string sinopse, double valorLoc, int estoque)  
            {
                new FilmeModels(idFilme, titulo, dataLanc, sinopse, valorLoc, estoque);
            }

    public string GetFilme(FilmeModels filme)
        {
            string filmeValue = filme.ToString();

            return filmeValue;
        }

        public static List<FilmeModels> GetFilmes()
			{
				return FilmeModels.GetFilmes();
			}
        
    }
}