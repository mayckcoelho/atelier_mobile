using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtelierMobileWS.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [Column("usuarioid")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("senha")]
        public string Senha { get; set; }
    }

    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
