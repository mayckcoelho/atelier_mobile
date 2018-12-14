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
    public class ClienteController : Controller
    {
        private readonly EntityContext _context;

        public ClienteController(EntityContext context)
        {
            _context = context;
        }

        // GET: api/cliente
        [Authorize("Bearer")]
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _context.Clientes.ToList();
        }

        // GET api/cliente/5
        [Authorize("Bearer")]
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _context.Clientes.Find(id);
        }

        // POST api/cliente
        [Authorize("Bearer")]
        [HttpPost]
        public void Post([FromBody]Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // PUT api/cliente/5
        [Authorize("Bearer")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Cliente cliente)
        {
            var clienteBase = _context.Clientes.Find(id);
            if (clienteBase != null)
            {
                clienteBase.Nome = cliente.Nome;
                clienteBase.Telefone = cliente.Telefone;

                _context.SaveChanges();
            }
        }

        // DELETE api/cliente/5
        [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cliente = _context.Clientes.Find(id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }
    }
}
