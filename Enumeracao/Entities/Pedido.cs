using System;
using Enumeracao.Entities.Enums; //aqui importamos a pasta Entities e depois a pasta Enums.
                                //com isso conseguimos chamar depois a classe PedidoStatus.

namespace Enumeracao.Entities { //atribuindo namespace nome do projeto ponto nome da pasta.
    class Pedido {

        public int Id { get; set; } //propriedade get set Id
        public DateTime Momento { get; set; } //propriedade get set Datetime que é o instante do pedido
        public PedidoStatus Status { get; set; } //chamando a classe PedidoStatus do tipo Enums. 

        //fazendo um to string para imprimir os atributos declarados acima.
        public override string ToString() {
            return Id
                + ", "
                + Momento
                + ", "
                + Status;
        }
    }
}
