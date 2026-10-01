using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace academia;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Profissional> Profissionais { get; set; }
    public DbSet<Plano> Planos { get; set; }
    public DbSet<Matricula> Matriculas { get; set; }
    public DbSet<AvaliacaoFisica> AvaliacoesFisicas { get; set; }
    public DbSet<Aula> Aulas { get; set; }
    public DbSet<Inscricao> Inscricoes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
}
