using Example.Transversal.domain.entities.car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.repositories.contracts.car
{
    /// <summary>
    /// Son las consultas a base de datos
    /// La implementa la capa de infraestructura
    /// </summary>
    public interface ICarRepository
    {
        string GetEngine();
        List<CarEntitie> GetCars();
        void Create(CarEntitie carEntitie);
    }
}
