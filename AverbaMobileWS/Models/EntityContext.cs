using System;
using System.Collections.Generic;
using System.Data;
using AtelierMobileWS.Models;
using Microsoft.EntityFrameworkCore;

namespace AtelierMobileWS.Models
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        public IList<dynamic> ExecuteCommand(string sqlCommand)
        {
            try
            {
                using (var command = this.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlCommand;
                    this.Database.OpenConnection();
                    using (var result = command.ExecuteReader())
                    {
                        var table = new DataTable();
                        table.Load(result);
                        return table.ToDynamic();
                        //while (result.Read())
                            ///etorno.Add(result.getta .GetString(0));
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
