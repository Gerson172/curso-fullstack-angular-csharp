using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;


namespace ProEvento.Persistence.Contexto
{
    public class ProEventosContext : DbContext
    {
        public ProEventosContext(DbContextOptions<ProEventosContext> options) : base(options) { }
        

        // criando as tabelas no db
        public DbSet<Evento> Eventos { get; set; } 
        public DbSet<Lote> Lotes { get; set; } 
        public DbSet<Palestrante> Palestrantes { get; set; } 
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; } 
        public DbSet<RedeSocial> RedeSociais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //chaves do palestrante evento
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new { PE.EventoId, PE.PalestranteId });

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.RedesSociais) // tem muitas redes sociais
                .WithOne(rs => rs.Evento)
                .OnDelete(DeleteBehavior.Cascade); // toda vez que tiver deletando,  ira deletar o evento e tbm a rede social em forma de cascata.

            modelBuilder.Entity<Palestrante>()
               .HasMany(e => e.RedesSociais) // tem muitas redes sociais
               .WithOne(rs => rs.Palestrante)
               .OnDelete(DeleteBehavior.Cascade); // toda vez que tiver deletando,  ira deletar o palestrante e tbm as redes sociais em forma de cascata
        }
    }
}
