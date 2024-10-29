using Microsoft.EntityFrameworkCore;

namespace TaskMaster.Models
{
    public class TaskMasterContext : DbContext
    {
        public TaskMasterContext(DbContextOptions<TaskMasterContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir as relações
            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Tarefas)
                .WithOne(t => t.Pessoa)
                .HasForeignKey(t => t.PessoaId);
        }
    }
}
