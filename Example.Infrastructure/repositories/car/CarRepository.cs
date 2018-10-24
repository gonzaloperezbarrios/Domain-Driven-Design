using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Domain.repositories.contracts.car;
using Example.Transversal.domain.entities.car;
using Example.Infrastructure.persistence.entityFramework;

namespace Example.Infrastructure.repositories.car
{
    /// <summary>
    /// Implementa la interfaz del dominio 
    /// La idea es que este conectado con una base de datos en la caperta persistence
    /// La carpeta persistence, tiene conexion a base de datos; ya sea entity framework o DAO
    /// </summary>
    public class CarRepository : ICarRepository
    {
        public void Create(CarEntitie carEntitie)
        {
            using (var db = new CarContext())
            {
                db.Car.Add(carEntitie);
                db.SaveChanges();
            }
        }

        public List<CarEntitie> GetCars()
        {
            using(var db=new CarContext())
            {
                return db.Car.ToList();
            }
        }

        public string GetEngine()
        {
            return "V8";
        }
    }
}
