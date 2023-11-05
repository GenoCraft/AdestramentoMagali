using System.Numerics;
using System.Text.Json;
using AdestramentoMagali.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;

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
            equipamento.Descricao = "Impede o cachorro de morder sla";
            equipamento.Quantidade = 2;

            Console.WriteLine(JsonSerializer.Serialize(equipamento));
            Assert.AreEqual(equipamento.Nome, "Focinheira");
            Assert.AreEqual(equipamento.Indicacao, "Guarda");
            Assert.AreEqual(equipamento.Descricao, "Impede o cachorro de morder sla");
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

            var equipamento = new Equipamento();

            var cidade = new Cidade();
            var cliente = new Cliente();
            var adestrador = new Adestrador();

            cidade.Nome = "Batatais";
            cidade.Estado = "SP";

            cliente.Nome = "Giovanna";
            cliente.Cidade = cidade;
            cliente.Bairro = "Centro";
            cliente.Endereco = "Rua Teste";

            equipamento.Nome = "Focinheira";
            equipamento.Indicacao = "Guarda";
            equipamento.Descricao = "Impede o cachorro de morder sla";
            equipamento.Quantidade = 2;

            cachorro.Nome = "Naruto";
            cachorro.Idade = 3;
            cachorro.Sexo = "Macho";
            cachorro.Raca = "Pit bull";
            cachorro.Porte = "Grande";
            cachorro.Peso = 21;
            cachorro.Temperamento = "Passivo-agressivo";
            cachorro.TipoAdestramento = "Guarda";
            cachorro.Plano = "Semanal";
            cachorro.Cliente = cliente;
            cachorro.Adestrador = adestrador;

            Console.WriteLine(JsonSerializer.Serialize(cachorro));
            Assert.AreEqual(cachorro.Nome, "Naruto");
            Assert.AreEqual(cachorro.Idade, 3);
            Assert.AreEqual(cachorro.Sexo, "Macho");
            Assert.AreEqual(cachorro.Raca, "Pit bull");
            Assert.AreEqual(cachorro.Porte, "Grande");
            Assert.AreEqual(cachorro.Peso, 21);
            Assert.AreEqual(cachorro.Temperamento, "Passivo-agressivo");
            Assert.AreEqual(cachorro.TipoAdestramento, "Guarda");
            Assert.AreEqual(cachorro.Plano, "Semanal");
            Assert.AreEqual(cachorro.Cliente, cliente);
            Assert.AreEqual(cachorro.Adestrador, adestrador);

            cachorro.Equipamentos.Add(equipamento);

            Console.WriteLine(JsonSerializer.Serialize(cachorro));
            Assert.AreEqual(cachorro.Equipamentos[0].Nome, equipamento.Nome);

        }

    }
}