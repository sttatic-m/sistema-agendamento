using Microsoft.EntityFrameworkCore;
using sistema_agendamento.Models;

namespace sistema_agendamento.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Patient> Patients { get; set; }
}