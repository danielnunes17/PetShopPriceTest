using PetshopPrice._2_DadosTransfObj;
using PetshopPrice.DadosLayers;
using System.Collections.Generic;
using System.Linq;

namespace PetshopPrice.RegraNegocio
{
    public class PetShopNegocio
    {
        public PetShopDTO ObterPetShopPorPreco(int quantidadeCachorroGrande, int quantidadeCachorroPequeno, bool isDiaSemana)
        {
            PetShopDados _dadosPet = new PetShopDados();

            List<PetShop> listaPetShops = _dadosPet.ObterListaPetshop();
            List<PetShopDTO> listaObjetos = new List<PetShopDTO>();


            //Percorre lista obtendo os preços totais
            foreach (var petShop in listaPetShops)
            {
                string nomePetShop = petShop.Nome;
                double precoTotalGrande = petShop.Preco.Where(precodia => precodia.IsDiaSemana == isDiaSemana).FirstOrDefault().PrecoDogG * quantidadeCachorroGrande;
                double precoTotalPequeno = petShop.Preco.Where(precodia => precodia.IsDiaSemana == isDiaSemana).FirstOrDefault().PrecoDogP * quantidadeCachorroPequeno;

                listaObjetos.Add(new PetShopDTO(nomePetShop, precoTotalGrande, precoTotalPequeno, petShop.Distancia));
            }


            return listaObjetos.OrderBy(distancia => distancia.Distancia)
                                .OrderBy(preco => preco.PrecoTotal)
                                .FirstOrDefault();
        }

    }
}
