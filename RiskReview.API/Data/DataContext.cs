using Microsoft.EntityFrameworkCore;
using RiskReview.API.Models;

namespace RiskReview.API.Data
{
    public class DataContext : DbContext
    {
        //Create constructor ctor
        public DataContext(DbContextOptions<DataContext>options) : base (options){}

        //Declare Properties
        public DbSet<Value> Values { get; set;} //Values is the table name in DB
    }
}