using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace DC_DentalCare.Models
{
    public class ReservaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {

            option.UseSqlServer("Data Source=JUPITER\\SQLEXPRESS;Initial Catalog=DentalCareORT;Encrypt=false;Integrated Security= true");


        }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Estado> Estados { get; set; }


    }

}
