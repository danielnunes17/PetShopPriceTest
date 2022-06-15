using PetshopPrice._2_DadosTransfObj;
using System.Collections.Generic;

namespace PetshopPrice.DadosLayers
{
    public class PetShopDados
    {
        /// <summary>
        /// Obtém os petshops
        /// </summary>
        public List<PetShop> ObterListaPetshop()
        {
            return PetShopMock();
        }

        /// <summary>
        /// Banco de Dados
        /// </summary>
        private List<PetShop> PetShopMock()
        {
            //Mock Lista Petshops
            List<PetShop> listaPetshop = new List<PetShop>
            {
                //Meu Canino
                new PetShop
                {
                    Nome = "Meu Canino",
                    Distancia = 2,
                    Preco = new List<Preco> {
                        new Preco{
                            IsDiaSemana = true,
                            PrecoDogG = 40,
                            PrecoDogP = 20
                        },
                        new Preco{
                            IsDiaSemana = false,
                            PrecoDogG = 48,
                            PrecoDogP = 24
                        }
                    }
                },

                //Vai Rex
                new PetShop
                {
                    Nome = "Vai Rex",
                    Distancia = 1.7,
                    Preco = new List<Preco> {
                        new Preco{
                            IsDiaSemana = true,
                            PrecoDogG = 50,
                            PrecoDogP = 15
                        },
                        new Preco{
                            IsDiaSemana = false,
                            PrecoDogG = 55,
                            PrecoDogP = 20
                        }
                    }
                },

                //ChowChawgas 
                new PetShop
                {
                    Nome = "ChowChawgas",
                    Distancia = 0.8,
                    Preco = new List<Preco> {
                        new Preco{
                            IsDiaSemana = true,
                            PrecoDogG = 45,
                            PrecoDogP = 30
                        },
                        new Preco{
                            IsDiaSemana = false,
                            PrecoDogG = 45,
                            PrecoDogP = 30
                        }
                    }
                }
            };

            return listaPetshop;
        }

    }
}
