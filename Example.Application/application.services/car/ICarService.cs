using Example.Transversal.domain.entities.car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.application.services.car
{
    /// <summary>
    /// Tiene los metodos que requiere la logica 
    /// </summary>
    public interface ICarService
    {
        string Turbo();
        List<CarEntitie> GetCars();
        void Create(CarEntitie carEntitie);
        void Update(CarEntitie carEntitie);
        void Delete(int id);
        CarEntitie GetCar(int id);
    }
}
