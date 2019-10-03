using System;
using Enumeracao.Entities;  //importando a pasta entidade para conseguir ver a classe pedido.
using Enumeracao.Entities.Enums; //importando a pasta entidade/Enums para conseguir ver a classe enum PedidoStatus.

namespace Enumeracao {
    class Program {
        static void Main(string[] args) {

            //instanciando a classe Pedido e atribuindo os valores nas propriedades da classe.
            Pedido pedido = new Pedido {
                Id = 1080,
                Momento = DateTime.Now,
                Status = PedidoStatus.PagamentoPendente
            };

            Console.WriteLine(pedido);

            //convertendo enumeração para string.
            string txt = PedidoStatus.PagamentoPendente.ToString();

            //convertendo string para enumeração com base na propriedade do netframework .net core 2.1
            PedidoStatus ps = Enum.Parse<PedidoStatus>("Entregue");

            //no netFramework4.5 precisamos fazer a seguinda ação para fazer a conversão 
            //variavel ps2 do tipo Classe "PedidoStatus", recebe ela (mesma), depois usamos o Enum.Parse para converter
            //adicionamos o tipo dela typeof(propriotipo da classe), e colocamos a string que desejamos converter.
            PedidoStatus ps2 = (PedidoStatus)Enum.Parse(typeof(PedidoStatus), "Entregue");

            //podemos ainda declarar uma variavel do tipo string que ira receber uma string e depois colocar a conversão para
            //Enumeração
            var minhaString = "Entregue"; //Console.ReadLine("usuario adiciona uma string aqui e depois e convertida").ToUpper();
            PedidoStatus ps3 = (PedidoStatus)Enum.Parse(typeof(PedidoStatus), minhaString);

            Console.WriteLine("Convertido para String: " + ps);
            Console.WriteLine("Convertido em Enum: " + ps2);
            Console.WriteLine("Declara uma variavel e é Convertido em Enum: " + ps3);
            Console.WriteLine(txt);
        }
    }
}
