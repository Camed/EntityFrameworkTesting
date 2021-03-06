using FizzBuzzEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzEntity.Data
{
    public class FizzBuzzContext : DbContext
    {
         public FizzBuzzContext(DbContextOptions options) : base(options) { }
         public DbSet<FizzBuzz> FizzBuzz { get; set; }
    }
}
