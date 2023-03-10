using Microsoft.EntityFrameworkCore;
using UniApiBackend.Models.DataModels;

namespace UniApiBackend.DataAccess
{
    public class UniversityContext: DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options): base(options) 
        { 

        }
        // Add DbSets (Table of our Data Base) "<User>" es la conexion a la clase User.cs, Users = nombre de la tabla
        public DbSet<User>? Users { get; set; } 
    }
}
