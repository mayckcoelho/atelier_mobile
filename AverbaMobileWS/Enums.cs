using System;
using System.ComponentModel;

namespace AtelierMobileWS
{
    public enum StatusCliente : int
    {
        Ativo = 1,
        Inativo = 2
    }

    public enum StatusPedido : int
    {
        Orcamento = 1,
        EmAndamento = 2,
        Entregue = 3,
        Cancelado = 4
    }

    public enum TipoRoupa : int
    {
        [Description("Calça")]
        Calca,
        Bermuda,
        Saia,
        Vestido,
        Blaser,
        Blusa
    }
}
