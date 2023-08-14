using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.ActionsMicroservice.Database
{
    public interface IDatabaseBuilder
    {
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    }
}
