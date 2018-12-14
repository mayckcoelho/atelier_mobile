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
    public class UsuarioController : Controller
    {
        private readonly EntityContext _context;

        public UsuarioController(EntityContext context)
        {
            _context = context;
        }

        // GET: api/usuario
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }

        // GET api/usuario/5
        [AllowAnonymous]
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _context.Usuarios.Find(id);
        }

        // POST api/usuario
        [AllowAnonymous]
        [HttpPost]
        public void Post([FromBody]Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // PUT api/usuario/5
        [AllowAnonymous]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Usuario usuario)
        {
            var usuarioBase = _context.Usuarios.Find(id);
            if (usuarioBase != null)
            {
                usuarioBase.Nome = usuario.Nome;
                usuarioBase.Login = usuario.Login;
                usuarioBase.Senha = usuario.Senha;

                _context.SaveChanges();
            }
        }

        // DELETE api/usuario/5
        [AllowAnonymous]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }
}
