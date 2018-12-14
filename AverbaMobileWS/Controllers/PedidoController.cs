using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtelierMobileWS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AtelierMobileWS.Controllers
{
    [Route("api/[controller]")]
    public class PedidoController : Controller
    {
        private readonly EntityContext _context;

        public PedidoController(EntityContext context)
        {
            _context = context;
        }

        // GET: api/pedido
        [Authorize("Bearer")]
        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _context.Pedidos.ToList();
        }

        // GET api/pedido/5
        [Authorize("Bearer")]
        [HttpGet("{id}")]
        public Pedido Get(int id)
        {
            return _context.Pedidos.Find(id);
        }

        // POST api/pedido
        [Authorize("Bearer")]
        [HttpPost]
        public void Post([FromBody]Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        // PUT api/pedido/5
        [Authorize("Bearer")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Pedido pedido)
        {
            var pedidoBase = _context.Pedidos.Find(id);
            if (pedidoBase != null)
            {
                pedidoBase.Valor = pedido.Valor;
                pedidoBase.TipoRoupa = pedido.TipoRoupa;
                pedidoBase.Foto = pedido.Foto;
                pedidoBase.DataEntrega = pedido.DataEntrega;
                pedidoBase.Status = pedido.Status;
                pedidoBase.Torax = pedido.Torax;
                pedidoBase.Busto = pedido.Busto;
                pedidoBase.Cintura = pedido.Cintura;
                pedidoBase.Quadril = pedido.Quadril;
                pedidoBase.LarguraCosta = pedido.LarguraCosta;
                pedidoBase.SeparacaoBusto = pedido.SeparacaoBusto;
                pedidoBase.AlturaBusto = pedido.AlturaBusto;
                pedidoBase.AlturaFrenteBlusa = pedido.AlturaFrenteBlusa;
                pedidoBase.AlturaCava = pedido.AlturaCava;
                pedidoBase.Ombro = pedido.Ombro;
                pedidoBase.LarguraBraco = pedido.LarguraBraco;
                pedidoBase.LarguraPunho = pedido.LarguraPunho;
                pedidoBase.AlturaMangaLonga = pedido.AlturaMangaLonga;
                pedidoBase.AlturaMangaCurta = pedido.AlturaMangaCurta;
                pedidoBase.AlturaQuadril = pedido.AlturaQuadril;
                pedidoBase.AlturaGancho = pedido.AlturaGancho;
                pedidoBase.AlturaJoelho = pedido.AlturaJoelho;
                pedidoBase.LarguraJoelho = pedido.LarguraJoelho;
                pedidoBase.AlturaTornozelo = pedido.AlturaTornozelo;
                pedidoBase.LarguraTornozelo = pedido.LarguraTornozelo;

                _context.SaveChanges();
            }
        }

        // DELETE api/pedido/5
        [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();
        }
    }
}
