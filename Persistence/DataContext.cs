using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    // Not specifically using the Unit of Work or Repository patterns as the DBContext instance is a combo
    // of those two patterns. As DBContext is an implementation of EntityFramework, so is an abstraction away
    // from our database, if those were to be used as well, it would represent an abstraction on top of an abstraction
    // and move away from the Clean Architecture pattern that we are using in our app
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        // A table named Activities using the Activity class to populate column names
        public DbSet<Activity> Activities { get; set; }
    }
}