using Microsoft.EntityFrameworkCore;
using sistema_agendamento.Models;

namespace sistema_agendamento.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public required DbSet<Patient> Patients { get; set; }
}