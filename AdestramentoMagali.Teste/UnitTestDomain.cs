using System.Text.Json;
using AdestramentoMagali.Domain.Entities;

namespace AdestramentoMagali.Teste
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCidade()
        {
            var cidade = new Cidade
            {
                Nome = "Batatais",
                Estado = "SP"
            };

            Console.WriteLine(JsonSerializer.Serialize(cidade));
            Assert.AreEqual(cidade.Nome, "Batatais");
            Assert.AreEqual(cidade.Estado, "SP");

        }
        [TestMethod]
        public void TestCliente() 
        {
            var cidade = new Cidade();
            var cliente = new Cliente();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";

            Console.WriteLine(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Giovanna");
            Assert.AreEqual(cliente.Cidade.Nome, cidade.Nome);
            Assert.AreEqual(cliente.Bairro, "Centro");
            Assert.AreEqual(cliente.Endereco, "Rua Teste");

        }
        [TestMethod]
        public void TesteEquipamento ()
        {
            var equipamento = new Equipamento();

            equipamento.Nome = "Focinheira";
            equipamento.Indicacao = "Guarda";
            equipamento.Quantidade = 2;

            Console.WriteLine(JsonSerializer.Serialize(equipamento));
            Assert.AreEqual(equipamento.Nome, "Focinheira");
            Assert.AreEqual(equipamento.Indicacao, "Guarda");
            Assert.AreEqual(equipamento.Quantidade, 2);

        }
        [TestMethod]
        public void TesteAdestrador()
        {
            var adestrador = new Adestrador();
            adestrador.Email = "teste@gmail.com";
            adestrador.Senha = "teste";
            adestrador.Telefone = 12345678901;
            adestrador.Especialidade = "Guarda";
            adestrador.DataCadastro = DateTime.Today;
            adestrador.Ativo = true;

            Assert.AreEqual(adestrador.Email, "teste@gmail.com");
            Assert.AreEqual(adestrador.Senha, "teste");
            Assert.AreEqual(adestrador.Telefone, 12345678901);
            Assert.AreEqual(adestrador.Especialidade, "Guarda");
            Assert.AreEqual(adestrador.DataCadastro, DateTime.Today);
            Assert.AreEqual(adestrador.Ativo, true);
        }

        [TestMethod]
        public void TesteCachorros ()
        {
            var cachorro = new Cachorro();
            var cachorroItem = new CachorroItem();

            var equipamento = new Equipamento();

            var cidade = new Cidade();
            var cliente = new Cliente();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";

            equipamento.Nome = "Focinheira";
            equipamento.Indicacao = "Guarda";
            equipamento.Quantidade = 2;

            cachorro.Cliente = cliente;
            cachorro.Data = DateTime.Today;

            Console.WriteLine(JsonSerializer.Serialize(cachorro));
            Assert.AreEqual(cachorro.Cliente, cliente);
            Assert.AreEqual(cachorro.Data, DateTime.Today);


            cachorroItem.Quantidade = 2;
            cachorroItem.Equipamento = equipamento;
            cachorroItem.ValorUnitario = 5;
            cachorroItem.Cachorro = cachorro;

            Console.WriteLine(JsonSerializer.Serialize(cachorroItem));
            Assert.AreEqual(cachorroItem.Quantidade, 2);
            Assert.AreEqual(cachorroItem.Equipamento, equipamento);
            Assert.AreEqual(cachorroItem.ValorUnitario, 5);
            Assert.AreEqual(cachorroItem.Cachorro, cachorro);

            cachorro.Items.Add(cachorroItem);


            Console.WriteLine(JsonSerializer.Serialize(cachorro));
            Assert.AreEqual(cachorro.Items[0].ValorUnitario, cachorroItem.ValorUnitario);

        }

    }
}