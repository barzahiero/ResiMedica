namespace ResiMedica.Domain.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ResiMedica.Common.Models.Product> Products { get; set; }
    }
}
