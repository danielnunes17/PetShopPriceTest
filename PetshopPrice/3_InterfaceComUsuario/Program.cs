using System;
using PetshopPrice.RegraNegocio;
using PetshopPrice._2_DadosTransfObj;


namespace PetshopPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            PetShopNegocio _negocio = new PetShopNegocio();
            DateTime data = new DateTime(16 / 06 / 2022);
            bool isDiaSemana = data.DayOfWeek != DayOfWeek.Saturday && data.DayOfWeek != DayOfWeek.Sunday;
            int quantidadeCachorroGrande = 3;
            int quantidadeCachorroPequeno = 2;


            PetShopDTO servico = _negocio.ObterPetShopPorPreco(quantidadeCachorroGrande, quantidadeCachorroPequeno, isDiaSemana);


            Console.WriteLine($"Nome do Petshop: {servico.NomePetShop}");

            Console.WriteLine("");

            Console.WriteLine($"Preço do banho em cão pequeno : R${servico.PrecoTotalDogP.ToString("n2")}");
            Console.WriteLine($"Preço do banho em cão grande : R${servico.PrecoTotalDogG.ToString("n2")}");
            Console.WriteLine($"Preço Total : R${servico.PrecoTotal.ToString("n2")}");
            Console.ReadLine();
        }
    }
}
