using Example.Transversal.domain.entities.car;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Infrastructure.persistence.entityFramework
{
    public class CarContext:DbContext
    {
        public CarContext() 
            :base("car_connection")
        {
        }

        public DbSet<CarEntitie> Car { get; set; }
    }
}
