using System;
using System.ComponentModel.DataAnnotations.Schema;
using AtelierMobileWS;

namespace AtelierMobileWS.Models
{
    [Table("pedido")]
    public class Pedido
    {
        [Column("pedidoid")]
        public int Id { get; set; }

        [Column("clienteid")]
        public int IdCliente { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("tipo_roupa")]
        public TipoRoupa TipoRoupa { get; set; }

        [Column("foto")]
        public string Foto { get; set; }

        [Column("data_entrega")]
        public DateTime DataEntrega { get; set; }

        [Column("status")]
        public StatusPedido Status { get; set; }

        #region Medidas
        [Column("torax")]
        public decimal? Torax { get; set; }

        [Column("busto")]
        public decimal? Busto { get; set; }

        [Column("cintura")]
        public decimal? Cintura { get; set; }

        [Column("quadril")]
        public decimal? Quadril { get; set; }

        [Column("largura_costa")]
        public decimal? LarguraCosta { get; set; }

        [Column("separacao_busto")]
        public decimal? SeparacaoBusto { get; set; }

        [Column("altura_busto")]
        public decimal? AlturaBusto { get; set; }

        [Column("altura_frente_blusa")]
        public decimal? AlturaFrenteBlusa { get; set; }

        [Column("altura_cava")]
        public decimal? AlturaCava { get; set; }

        [Column("ombro")]
        public decimal? Ombro { get; set; }

        [Column("largura_braco")]
        public decimal? LarguraBraco { get; set; }

        [Column("largura_punho")]
        public decimal? LarguraPunho { get; set; }

        [Column("altura_manga_longa")]
        public decimal? AlturaMangaLonga { get; set; }

        [Column("altura_manga_curta")]
        public decimal? AlturaMangaCurta { get; set; }

        [Column("altura_quadril")]
        public decimal? AlturaQuadril { get; set; }

        [Column("altura_grancho")]
        public decimal? AlturaGancho { get; set; }

        [Column("altura_joelho")]
        public decimal? AlturaJoelho { get; set; }

        [Column("largura_joelho")]
        public decimal? LarguraJoelho { get; set; }

        [Column("altura_tornozelo")]
        public decimal? AlturaTornozelo { get; set; }

        [Column("largura_tornozelo")]
        public decimal? LarguraTornozelo { get; set; }
        #endregion

        public virtual Cliente Cliente { get; set; }
    }
}
