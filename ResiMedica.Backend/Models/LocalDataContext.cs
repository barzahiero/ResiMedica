namespace ResiMedica.Backend.Models
{
    using Domain.Models;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<ResiMedica.Common.Models.Product> Products { get; set; }
    }
}