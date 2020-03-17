using Models;
using System.Collections.Generic;

namespace Repositories
{
    public class FilmeRepositories
    {
		public static List<FilmeModels> filmes = new List<FilmeModels>();

		public static void ImportarFilme()
		{
        // Lista com 10 Filmes
			FilmeModels filme1 = new FilmeModels(1, "Ben Hur", 
				"25/01/1958", 
				"Ben-Hur é um mercador judeu que, após um desentendimento, é condenado a viver como escravo por um amigo de juventude,\n Messala, que é o chefe das legiões romanas da cidade. Mas uma surpreendente oportunidade de vingança surge de onde ele menos espera.",
				4.5, 5);
			//filmes.Add(filme1);

			FilmeModels filme2 = new FilmeModels(2, "Encontro Marcado",
				"08/10/1998",
				"Quando o Anjo da Morte chega à Terra para buscar um magnata da mídia, suas experiências como mortal o levam a se apaixonar\n   pela filha do milionário. A Morte então decide fazer um acordo com o empresário para que ambos possam permanecer mais tempo na Terra.",
				3.5, 3);
			//filmes.Add(filme2);

			FilmeModels filme3 = new FilmeModels(3, "Crash", 
				"01/05/2004",
				"Tensões raciais emergem em uma série de histórias envolvendo moradores de Los Angeles. Diversos personagens das mais\n   variadas origens étnicas se cruzam em um incidente. Os diferentes estereótipos que a sociedade criou para esses grupos raciais afeta seu\n   julgamento, crenças e atitudes, o que causa problemas e tensões para todos.",
				2.5, 2);
			//filmes.Add(filme3);

			FilmeModels filme4 = new FilmeModels(4, "Endiabrado", 
				"20/11/2004",
				"Desesperado para ganhar a afeição de uma bela colega de trabalho, Elliot faz um acordo com o Diabo, uma mulher maravilhosa,\n   com um perverso senso de humor. Em troca da alma de Elliot, ela vai lhe conceder sete desejos, mas a cada desejo, ele recebe mais\n   do que pede.",
				2.5, 1);
			//filmes.Add(filme4);

			FilmeModels filme5 = new FilmeModels(5, "Tomates Verdes Fritos",
				"05/03/2001",
				"Evelyn Couch (Kathy Bates) visita com o marido um parente no asilo de idosos. Uma vez lá, ela encontra Ninny Threadgoode\n   (Jessica Tandy), uma mulher idosa, que a ilumina e traz uma nova perspectiva através de contos do seu passado. Evelyn ganha a confiança\n   necessária para mudar sua própria vida para melhor.",
				3.5, 2);
			//filmes.Add(filme5);

			FilmeModels filme6 = new FilmeModels(6, "Robocop",
				"18/09/1997",
				"Policial é morto em combate e transformado por cientistas da empresa que dirige a força policial em um ciborgue\n   ultrassofisticado a fim de ser usado na luta contra o crime na cidade de Detroit. Porém, apesar de ter sua memória apagada,\n   lembranças o assombram e o levam a buscar vingança.",
				2.5, 2);
			//filmes.Add(filme6);

			FilmeModels filme7 = new FilmeModels(7, "Harry Potte e o Prisioneiro de Azkaban",
				"07/08/2004",
				"O terceiro ano de Harry Potter em Hogwarts começa mal quando ele descobre que o assassino Sirius Black escapou da prisão\n   de Azkaban e está empenhado em matá-lo. Enquanto o gato de Hermione atormenta o rato doente de Ron, um bando de dementadores são enviados\n   para proteger a escola de Sirius Black. Um professor misterioso ajuda Harry a aprender a se defender.",
				3.5, 3);
			//filmes.Add(filme7);

			FilmeModels filme8 = new FilmeModels(8, "Psicose",
				"15/10/1960",
				"Após roubar 40 mil dólares para se casar com o namorado, uma mulher foge durante uma tempestade e decide passar a noite em\n   um hotel que encontra pelo caminho. Ela conhece o educado e nervoso proprietário do estabelecimento, Norman Bates, um jovem com um\n   interesse em taxidermia e com uma relação conturbada com sua mãe. O que parece ser uma simples estadia no local se torna uma verdadeira noite de terror.",
				3.5, 1);
			//filmes.Add(filme8);

			FilmeModels filme9 = new FilmeModels(9, "Jamaica Abaixo de Zero",
				"07/05/1993",
				"Quatro jamaicanos praticantes de bobsleigh sonham em competir nos Jogos Olímpicos de Inverno, apesar de nunca terem visto\n   neve. Com a ajuda de um ex-campeão desonrado desesperado para se redimir, os jamaicanos decidem tentar a classificação para a seleção\n   olímpica e buscar a glória.",
				2.5, 3);
			//filmes.Add(filme9);

			FilmeModels filme10 = new FilmeModels(10, "Vingadores Ultimato",
				"16/07/2019",
				"Após Thanos eliminar metade das criaturas vivas, os Vingadores têm de lidar com a perda de amigos e entes queridos.\n   Com Tony Stark vagando perdido no espaço sem água e comida, Steve Rogers e Natasha Romanov lideram a resistência contra o titã louco.",
				4.5, 8);
			//filmes.Add(filme10);
		}
    }
}