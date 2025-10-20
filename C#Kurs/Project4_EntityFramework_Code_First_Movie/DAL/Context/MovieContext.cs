using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFramework_Code_First_Movie.DAL.Context
{
    public class MovieContext:DbContext
    {
        public DbSet<Entities.Movie> Movies { get; set; }

        public DbSet<Entities.Category> Categories { get; set; }

    }
}
