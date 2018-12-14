using System;
using System.ComponentModel.DataAnnotations.Schema;
using AtelierMobileWS;
using AtelierMobileWS.Models;

namespace AtelierMobileWS.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Column("clienteid")]
        public int Id { get; set; }

        [Column("usuarioid")]
        public int IdUsuario { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("status")]
        public StatusCliente Status { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
