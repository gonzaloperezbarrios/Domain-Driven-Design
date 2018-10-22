using Example.Domain.repositories.contracts.car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Domain.domain.services.car
{
    /// <summary>
    /// La idea de esta clase es que tenga la logica de negocio
    /// ICarRepository -> es para hecer consultas a base de datos
    /// </summary>
    public class CarService : ICarService
    {
        ICarRepository _iCarRepository;

        public CarService(ICarRepository iCarRepository)
        {
            this._iCarRepository = iCarRepository;
        }

        public string Turbo()
        {
            return _iCarRepository.GetEngine()+ "With Nitro";
        }
    }
}
