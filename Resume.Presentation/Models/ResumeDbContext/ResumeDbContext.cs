using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Exprience;

namespace Resume.Presentation.Models.ResumeDbContext;

public class ResumeDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=Z-LAPTOP;Database=ResumeDb;User Id=sa;Password=123456789;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Exprience> Expriences{ get; set; }
    public DbSet<Entities.Education.Education> Educations { get; set; }
    public DbSet<Entities.MySkills.MySkills> MySkills { get; set; }
}   
