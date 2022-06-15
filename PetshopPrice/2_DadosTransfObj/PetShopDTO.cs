namespace PetshopPrice._2_DadosTransfObj
{
    public class PetShopDTO
    {
        public PetShopDTO(string nomePetShop, double precoTotalDogG, double precoTotalDogP, double distancia)
        {
            NomePetShop = nomePetShop;
            PrecoTotalDogG = precoTotalDogG;
            PrecoTotalDogP = precoTotalDogP;
            Distancia = distancia;


            PrecoTotal = precoTotalDogG + precoTotalDogP;
        }

        public string NomePetShop { get; set; }
        public double PrecoTotalDogG { get; set; }
        public double PrecoTotalDogP { get; set; }
        public double Distancia { get; set; }
        public double PrecoTotal { get; set; }
    }
}
