namespace Enumeracao.Entities.Enums { //atribuindo namespace nome do projeto ponto nome da pasta e subpasta
    enum PedidoStatus : int { //trocamos de tipo "class" para "enum" e especificar que cada valor será um
                              //um número inteiro com o : int derivando os tipos dela.
        
        //Declarando os valores possiveis para a nossa enumeração.
        PagamentoPendente = 0,  
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}

