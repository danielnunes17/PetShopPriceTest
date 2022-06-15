Nome: Daniel Stephanio Nunes
Vaga: Desenvolvedor

Instruções gerais

Framewrk útilizado: .NET core 3.1
Linguagem: C# 8.0
Visual Studio 2022

Premissas assumidas

Decisões de projeto

1 -A principio foquei em resolver o problema de forma simples, na Main mesmo, escolhendo apenas um PetShop e aplicando o cálculo.

2 - Na pasta 2_DadosTransfObj/PetShopDTO, criei os atributos que seriam comum aos 3 PetShops e um construtor contendo as informações.
Em 2_DadosTransfObj/PetShop, criei uma lista de preço a ser instaciada
Em 2_DadosTransfObj/Preco, criei atributos para obter os preços.

3 - Definição da regra de negócio (Pasta: 1_RegraNegocio).
Invoquei o construtor obterPetShopPorPreco,
Criei o obejo _dadosPet e uma lista de objetos.
Implementei um foreach para obeter os preços totais retornando a lista de objeto por ordem.
Utilizei o lambda e o método operador de consulta Where para obter e organizar o return.


*Instruções para executar o sistema*

Ao abrir o Visual Studio, entrar na pasta 3_IntefaceComUsuario

em C# Program.cs

Inserir a data em  DateTime data = new DateTime(2022, 06, 14);

Inserir as quantidades de banhos de acordo com os tamanhos dos cachorros em:

int quantidadeCachorroGrande = 3;
int quantidadeCachorroPequeno = 5;

Executar: Ctrl F5


