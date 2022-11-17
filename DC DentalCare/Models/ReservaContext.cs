using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace DC_DentalCare.Models
{
    public class ReservaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {

            option.UseSqlServer("Data Source=DESKTOP-KGSGH6K\\SQLEXPRESS ; Initial Catalog=Ventas ; Integrated Security= true");


        }
        public DbSet<ReservaContext> Reservas { get; set; }


    }

}
